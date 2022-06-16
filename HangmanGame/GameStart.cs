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
        StringBuilder result;
        GameMananger gameMananger;
        

        public GameStart(int lvlChose)
        {
            gameMananger = new GameMananger();
            easyWord = new EasyWord(random.Next(3, 5));
            mediumWord = new MediumWord(random.Next(5, 7));

            if(lvlChose == gameMananger.EasyLvlChose)
            {
                resultStartSet(easyWord);
                
            }else if(lvlChose == gameMananger.MediumLvlChose)
            {
                resultStartSet(mediumWord);
            }
        }

        

        public void resultStartSet(WordClass word)
        {
            result = new StringBuilder(word.Word.Length);
            for (int i = 0; i < result.Length * 2; i++)
            {
                if(i % 2 == 0)
                {
                    result[i] = '_';
                }
                else
                {
                    result[i] = ' ';
                }
            }
        } 
    }
}
