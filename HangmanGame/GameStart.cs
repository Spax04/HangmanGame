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
        GameMananger gameMananger;
        private char[] _playerWord;

        public GameStart(int lvlChose)
        {
            result = new StringBuilder();
            gameMananger = new GameMananger(); //Added to display a lvl Chose
            easyWord = new EasyWord(random.Next(3, 5));
            mediumWord = new MediumWord(random.Next(5, 7));
            hardWord = new HardWord(random.Next(7, 9));

            if(lvlChose == gameMananger.EasyLvlChose)
            {
                result = resultStartSet(easyWord);
                _playerWord = easyWord.Word;
                 
            }
            else if(lvlChose == gameMananger.MediumLvlChose)
            {
                result = resultStartSet(mediumWord);
                _playerWord = mediumWord.Word;
            }else if(lvlChose == gameMananger.HardLvlChose)
            {
                result = resultStartSet(hardWord);
                _playerWord = hardWord.Word;
            }
        }
        public int letterCheck(char c, char[] word)  //ref numm for counter double chares
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

            for(int i = 0; i < word.Word.Length*2; i++)
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
