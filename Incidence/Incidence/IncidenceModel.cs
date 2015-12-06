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

        private string[] wordSeparator =  { " ", ". ", "!", "?" };

        public void Calculate()
        {
            TextPreProcessing();
            DictionaryPreProcessing();
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

        private string ClearUnnecessarySymbols(string text)
        {
            text = text.Replace(",", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace(":", "");
            text = text.Replace(";", "");
            text = text.Replace(",", "");
            text = text.Replace("-", "");
            text = text.Replace("\"", "");
            text = text.Replace("\r", " ");
            text = text.Replace("\n", " ");
            return text;
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
