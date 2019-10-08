using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Robot : BasePlayer
    {
        public override string GetName()
        {
            return "R0B0T";
        }

        public override int GuessNumber()
        {
            Thread.Sleep(1000);

            if (NextGuess == 0)
            {
                CurrentGuess = new Random().Next(1, 500);

            }
            else if (NextGuess == -1)
            {
                CurrentGuess = new Random().Next(1, CurrentGuess);
            }
            else if (NextGuess == 1)
            {
                CurrentGuess = new Random().Next(CurrentGuess + 1, 500);
            }

            Console.WriteLine("Robot guess: {0}", CurrentGuess);

            return CurrentGuess;
        }
    }
}
