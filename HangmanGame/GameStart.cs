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
        private string final;


        public GameStart(int lvlChose)
        {
            
            gameMananger = new GameMananger(); //Added to display a lvl Chose
            easyWord = new EasyWord(random.Next(3, 5));
            mediumWord = new MediumWord(random.Next(5, 7));

            if(lvlChose == gameMananger.EasyLvlChose)
            {
                result = resultStartSet(easyWord);
                final = result.ToString();
            }
            else if(lvlChose == gameMananger.MediumLvlChose)
            {
                result = resultStartSet(mediumWord);
                final=result.ToString();
            }
        }

        

        public StringBuilder resultStartSet(WordClass word)
        {
           StringBuilder sb = new StringBuilder(word.Word.Length*2);
            for (int i = 0; i < sb.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sb.Insert(i,"_");
                }
                else
                {
                    sb.Insert(i, " ");
                }
            }
            return sb;
        } 
        public string Final { get { return final; } }
        public StringBuilder Result { get { return result; } }
    }
}
