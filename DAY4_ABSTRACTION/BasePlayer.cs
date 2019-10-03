using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    abstract class BasePlayer : IPlayer
    {
        string Name;
        int CurrentGuess;

        bool IsNumberGuessed(int number)
        {

        }

        abstract string GetName()
        {

        }

        public int GuessNumber()
        {

        }
    }
}
