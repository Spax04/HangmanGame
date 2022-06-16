using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class GameMananger
    {
        private const int _easyLvlChose = 1;
        private const int _mediumLvlChose = 2;

        
        public int EasyLvlChose { get { return _easyLvlChose; } }
        public int MediumLvlChose { get { return _mediumLvlChose; } }
    }
}
