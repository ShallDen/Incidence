using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidence
{
    public class IncidenceModel
    {
        public string mText = string.Empty;
        public string mClearedText = string.Empty;
        public List<string> mWordList;
        public List<string> mLowerWordList;

        public string mDictionaryText = string.Empty;
        public string mClearedDictionaryText = string.Empty;
        public List<string> mLowerDictionaryList;
        public List<string> mLowerWordDictionaryList;

        public List<string> mTerminList;

        public List<string> mSentenceList;
        public List<string> mLowerSentenceList;

        private string[] wordSeparator =  { " ", ". ", "!", "?" };
        private string[] sentenceSeparator =  { ". ", "!", "?", "\r\n" };

        public int[,] mIncedenceMatrix;

        public void Calculate()
        {
            InitializeTextItems();
            TextPreProcessing();
            DictionaryPreProcessing();
            SentencePreProcessing();
            FindTermins();
            InitializeMatrix();
            FillMatrix();
        }

        public void InitializeTextItems()
        {
            mClearedText = string.Empty;
            mWordList = new List<string>();
            mLowerWordList = new List<string>();
            mClearedDictionaryText = string.Empty;
            mLowerDictionaryList = new List<string>();
            mLowerWordDictionaryList = new List<string>();
            mTerminList = new List<string>();
            mSentenceList = new List<string>();
            mLowerSentenceList = new List<string>();
        }

        private void TextPreProcessing()
        {
            mClearedText = ClearUnnecessarySymbols(mText);
            mWordList = CreateListOfWords(mClearedText);
            mLowerWordList = WordsToLowerCase(mWordList);
        }

        private void DictionaryPreProcessing()
        {
            mClearedDictionaryText = ClearUnnecessarySymbols(mDictionaryText);
            mLowerDictionaryList = CreateListOfWords(mClearedDictionaryText);
            mLowerWordDictionaryList = WordsToLowerCase(mLowerDictionaryList);
        }

        private void SentencePreProcessing()
        {
            mSentenceList = CreateListOfSentence(mClearedText);
            mLowerSentenceList = WordsToLowerCase(mSentenceList);
        }

        private List<String> CreateListOfSentence(string text)
        {
            return text.Split(sentenceSeparator, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private string ClearUnnecessarySymbols(string text)
        {
            text = text.Replace(",", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(":", "")
                .Replace(";", "")
                .Replace(",", "")
                .Replace("-", "")
                .Replace("\"", "")
                .Replace("\r", " ")
                .Replace("\n", " ");

            return text;
        }

        private void FindTermins()
        {
            foreach(var textWord in mLowerWordList)
            {
                foreach(var dictionaryWord in mLowerWordDictionaryList)
                {
                    if(textWord == dictionaryWord)
                    {
                        mTerminList.Add(textWord);
                    }
                }
            }

            mTerminList = mTerminList.Distinct().ToList(); //delete repeating words
        }

        private List<string> CreateListOfWords(string text)
        {
            return text.Split(wordSeparator, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private List<string> WordsToLowerCase(List<string> list)
        {
            return list.Select(c => c.ToLower()).ToList(); 
        }

        private void InitializeMatrix()
        {
            mIncedenceMatrix = new int[mTerminList.Count, mTerminList.Count];
            for (int i = 0; i < mTerminList.Count; i++)
                for (int j = 0; j < mTerminList.Count; j++)
                    mIncedenceMatrix[i, j] = 0;
        }
         
        private void FillMatrix()
        {
            int i = 0;
            foreach (var termin in mTerminList)
            {
                List<string> sentences = FindSentenseByWord(termin);

                foreach (var sentence in sentences)
                {
                    int j = 0;
                    foreach (var internalTermin in mTerminList)
                    {
                        if (internalTermin == termin || mIncedenceMatrix[i, j] == 1)
                        {
                            j++;
                            continue;
                        }

                        if (sentence.Contains(internalTermin))
                            mIncedenceMatrix[i, j] = 1;
                        else
                            mIncedenceMatrix[i, j] = 0;

                        j++;
                    }
                }
                i++;
            }
        }

        private List<string> FindSentenseByWord(string word)
        {
            List<string> foundedSententences = new List<string>();
            foreach(var sentense in mLowerSentenceList)
            {
                if (sentense.Contains(word))
                    foundedSententences.Add(sentense);
            }

            return foundedSententences;
        }
    }
}
