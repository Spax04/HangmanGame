using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class MediumWord : WordClass
    {
        Random random = new Random();
        private string[] _mediumCollectionFive = { "CLOWN", "PARTY", "RODEO", "THREE", "MEDIA" }; //Defuelt length = 5;
        private string[] _mediumCollectionSix = { "CHOICE", "SISTER", "CHILLI", "REMOVE", "WRITER" }; //Defuelt length = 5;
        private const int _mediumLengthFive = 5;
        private const int _mediumLengthSix = 6;
        public MediumWord(int maxWordLength) : base(maxWordLength)
        {
            if (maxWordLength == _mediumLengthFive)
            {
                addCharToWord(_mediumCollectionFive[random.Next(_mediumCollectionFive.Length)]); // sets randome word from mediumCollectionFive ( 5 chars)
            }
            else if (maxWordLength == _mediumLengthSix)
            {
                addCharToWord(_mediumCollectionSix[random.Next(_mediumCollectionSix.Length)]); // randome word from mediumCollectionSix ( 6 chars)
            }
        }
    }
}
