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
        public List<string> mWordList = new List<string>();
        public List<string> mLowerWordList = new List<string>();

        public string mDictionaryText = string.Empty;
        public string mClearedDictionaryText = string.Empty;
        public List<string> mLordDictionaryList = new List<string>();
        public List<string> mLowerWordDictionaryList = new List<string>();

        public List<string> mTerminList = new List<string>();
        public List<string> mSentenceList = new List<string>();

        private string[] wordSeparator =  { " ", ". ", "!", "?" };
        private string[] sentenceSeparator =  { ". ", "!", "?", "\r\n" };

        public void Calculate()
        {
            TextPreProcessing();
            DictionaryPreProcessing();
            SentencePreProcessing();
            FindDictionaryItems();
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
            mLordDictionaryList = CreateListOfWords(mClearedDictionaryText);
            mLowerWordDictionaryList = WordsToLowerCase(mLordDictionaryList);
        }

        private void SentencePreProcessing()
        {
            mSentenceList = CreateListOfSentence(mText);
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

        private void FindDictionaryItems()
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

    }
}
