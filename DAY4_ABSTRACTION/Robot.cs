using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class Robot : BasePlayer
    {
        public override string GetName()
        {
            return "R0B0T";
        }

        public override int GuessNumber()
        {
            Random rnd = new Random();
            CurrentGuess = rnd.Next(1, 500);

            return CurrentGuess;
        }
    }
}
