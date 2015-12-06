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
        public List<string> wordList = new List<string>();
        public List<string> lowerWordList;
        string[] wordSeparator =  { " ", ". ", "!", "?" };

        public void Calculate()
        {
            PreProcessing();
        }

        private void PreProcessing()
        {
            ClearUnnecessarySymbols();
            CreateListOfWords();
            WordsToLowerCase();
        }

        private void ClearUnnecessarySymbols()
        {
            mText = mText.Replace(",", "");
            mText = mText.Replace("(", "");
            mText = mText.Replace(")", "");
            mText = mText.Replace(":", "");
            mText = mText.Replace(";", "");
            mText = mText.Replace(",", "");
            mText = mText.Replace("-", "");
            mText = mText.Replace("\"", "");
            mText = mText.Replace("\r", " ");
            mText = mText.Replace("\n", " ");
        }

        private List<string> CreateListOfWords()
        {
            wordList = mText.Split(wordSeparator, StringSplitOptions.RemoveEmptyEntries).ToList();
            return wordList;
        }

        private List<string> WordsToLowerCase()
        {
            lowerWordList = wordList.Select(c => c.ToLower()).ToList();
            return lowerWordList;
        }

    }
}
