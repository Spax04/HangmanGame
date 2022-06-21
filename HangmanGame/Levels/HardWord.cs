using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class HardWord : WordClass
    {
        Random random = new Random();
        private string[] _hardCollectionSeven = { "ACCOUNT", "BROTHER", "COLLEGE", "VIRTUAL", "MILLION" }; //Defuelt length = 5;
        private string[] _hardCollectionEight = { "DELIVERY", "FESTIVAL", "LANGUAGE", "OPTIMISM", "STANDARD" }; //Defuelt length = 5;
        private const int _hardLengthSeven = 7;
        private const int _hardLengtEight = 8;
        public HardWord(int maxWordLength) : base(maxWordLength)
        {
            if (maxWordLength == _hardLengthSeven)
            {
                addCharToWord(_hardCollectionSeven[random.Next(_hardCollectionSeven.Length)]); // sets randome word from mediumCollectionFive ( 5 chars)
            }
            else if (maxWordLength == _hardLengtEight)
            {
                addCharToWord(_hardCollectionEight[random.Next(_hardCollectionEight.Length)]); // randome word from mediumCollectionSix ( 6 chars)
            }
        }
    }
}
