using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class GameStart
    {
        Random random = new Random();
        EasyWord easyWord;
        MediumWord mediumWord;
        HardWord hardWord;
        StringBuilder result;
        private char[] _playerWord;

        public GameStart(LevelChoses ls)
        {
            result = new StringBuilder();

            easyWord = new EasyWord(random.Next(3, 5)); // When game was created, those fields contein some random word.
            mediumWord = new MediumWord(random.Next(5, 7));
            hardWord = new HardWord(random.Next(7, 9));

            if(ls == LevelChoses.easyLvl)
            {
                result = resultStartSet(easyWord);
                _playerWord = easyWord.Word;  
            }
            else if(ls == LevelChoses.mediumLvl)
            {
                result = resultStartSet(mediumWord);
                _playerWord = mediumWord.Word;
            }
            else if(ls == LevelChoses.hardLvl)
            {
                result = resultStartSet(hardWord);
                _playerWord = hardWord.Word;
            }
        }
        public int letterCheck(char c, char[] word)  
        {
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == c)
                {
                    result[i * 2] = c;
                    count++;
                }
            }
           return count;  
        }
        public StringBuilder resultStartSet(WordClass word)
        {
             StringBuilder sb = new StringBuilder();

            for(int i = 0; i < word.Word.Length*2; i++)  // Without this field, result field looks like this "___" ,and I wanted to make some space between letters "_ _ _"
            {
                if (i % 2 == 0)
                {
                    sb.Append("_");
                }
                else
                {
                    sb.Append(" ");
                }
            }
            return sb;
        } 
        
        public char[] PlayerWord { get { return _playerWord; } }
        public StringBuilder Result { get { return result; } }
    }
}
