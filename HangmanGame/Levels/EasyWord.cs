using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class EasyWord : WordClass
    {
        Random random = new Random();
        string[] _easyCollectionThree = { "DOG", "CAT", "TEA", "BUG", "SET","SAD","PAN","POT","HAT","HOT","ZIP","BOX","FOX","YOU"}; //Defuelt length = 14;
        string[] _easyCollectionFour = { "DATE", "MAIL", "SOUP", "LION", "GOAT", "BALL","MAIN","TAXI"}; //Defuelt length = 5;
        private const int _easyLengthThree = 3;
        private const int _easyLengthFour = 4;
        
        public EasyWord(int maxWordLength) : base(maxWordLength)   //Object Easy Word has got chare arrey width length 3 or 4.
        {
            if(maxWordLength == _easyLengthThree)
            {
                addCharToWord(_easyCollectionThree[random.Next(_easyCollectionThree.Length)]); // randome word from easyCollectionThree ( 3 chars)
            }
            else if(maxWordLength == _easyLengthFour)
            {
                addCharToWord(_easyCollectionFour[random.Next(_easyCollectionFour.Length)]); // randome word from easyCollectionFour ( 4 chars)
            }
        }

    }
}
