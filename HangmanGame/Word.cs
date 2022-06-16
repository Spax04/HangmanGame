using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HangmanGame
{
    internal class Word
    {
        private char[] _word;
        private readonly int maxWordLength;
        public Word(int maxWordLength)
        {
            this.maxWordLength = maxWordLength;
            _word = new char[maxWordLength];
        }
       
        public void addChareToWord(string word) // User shold adds the word into parameter by CAPS. Example: HOME, WORD,DOG e.t.
        {
            if(word.Length == maxWordLength)
            {
                for(int i = 0; i<word.Length;i++)
                {
                    _word[i] = word[i];
                }
            }
        }

        public char[] _Word { get { return _word; } }

        
    }
}
