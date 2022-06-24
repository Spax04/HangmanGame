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
       
        //Missing amount
        private const int _easyMissAmount = 6;
        private const int _mediumMissAmount = 8;
        private const int _hardMissAmount = 10; 

        private static int _missCounter;
        private int _maxMiss;
        private static int _guessCounter;
        private int _wordLength;
        public GameMananger()
        {
            _guessCounter = 0;
            _missCounter = 0;
        }

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

      
        public int EasyMissAmount { get { return _easyMissAmount; } }
        public int MediumMissAmount { get { return _mediumMissAmount; } }
        public int HardMissAmount { get { return _hardMissAmount; } } // Working on it
    }
}
