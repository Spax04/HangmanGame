using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HangmanGame
{
    public class WordClass
    {
        

        private char[] _word;
        private readonly int maxWordLength;
        public WordClass(int maxWordLength)
        {
            this.maxWordLength = maxWordLength;
            _word = new char[maxWordLength];
        }
       
        public void addCharToWord(string word) // User shold adds the word into parameter by CAPS. Example: HOME, WORD,DOG e.t.
        {
            word.ToUpper();
            if(word.Length == maxWordLength)
            {
                for(int i = 0; i<word.Length;i++)
                {
                    _word[i] = word[i];
                }
            }
        }

        public char[] Word { get { return _word; } set { _word = value; } }

        public int Length { get; internal set; }
    }
}
