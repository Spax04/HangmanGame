﻿using System;
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
        private char[] _playerWord;


        public GameStart(int lvlChose)
        {
            result = new StringBuilder();
            gameMananger = new GameMananger(); //Added to display a lvl Chose
            easyWord = new EasyWord(random.Next(3, 5));
            mediumWord = new MediumWord(random.Next(5, 7));

            if(lvlChose == gameMananger.EasyLvlChose)
            {
                result = resultStartSet(easyWord);
                _playerWord = easyWord.Word;
                 
            }
            else if(lvlChose == gameMananger.MediumLvlChose)
            {
                result = resultStartSet(mediumWord);
                _playerWord = mediumWord.Word;
            }
        }


        public bool letterCheck(char c, char[] word, ref int num)
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
            num+=count;
            if(count > 0)
                return true;
            else
                return false;
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
