using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace HangmanGame
{
    internal class GameMananger
    {
        //Levels
        private const int _easyLvlChose = 1;
        private const int _mediumLvlChose = 2;
        private const int _hardLvlChose = 3; // Working on it
        //Missing amount
        private const int _easyMissAmount = 10;
        private const int _mediumMissAmount = 8;
        private const int _hardMissAmount = 6; // Working on it

        private int _missCounter;
        private int _maxMiss;
        private int _guessCounter;
        private int _wordLength;
        public GameMananger()
        {
            _guessCounter = 0;
            _missCounter = 0;
        }

        /*public bool missCounterMethod(bool status)
        {
            if(status == false)
            {
                _missCounter++;
            }
            if(_missCounter == _maxMiss) //Game Over Checking
            {
                return true;
            }
            return false;
        }*/

        public bool winCheck()
        {
            if(_guessCounter == _wordLength)
                return true;
            else 
                return false;
        }

        public bool looseCheck()
        {
            if (_missCounter == _maxMiss)
                return true;
            else
                return false;
        }
       
        public int MaxMiss { get{ return _maxMiss; } set { _maxMiss = value; } }
        public int MissCounter { get { return _missCounter; } set { _missCounter = value; }  }
        public int GuessCounter { get { return _guessCounter; } set { _guessCounter = value; } }
        public int WordLength { get { return _wordLength; } set { _wordLength = value; } }

        public int EasyLvlChose { get { return _easyLvlChose; } }
        public int MediumLvlChose { get { return _mediumLvlChose; } }
        public int HardLvlChose { get { return _hardLvlChose; } } // Working on it

        public int EasyMissAmount { get { return _easyMissAmount; } }
        public int MediumMissAmount { get { return _mediumMissAmount; } }
        public int HardMissAmount { get { return _hardMissAmount; } } // Working on it
    }
}
