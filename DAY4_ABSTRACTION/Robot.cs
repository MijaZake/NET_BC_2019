using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// Contains all methods needed for an AI player of the game.
    /// </summary>
    public class Robot : BasePlayer
    {
        /// <summary>
        /// Returns predefined name of the player.
        /// </summary>
        /// <returns>Name of the player.</returns>
        public override string GetName()
        {
            return "R0B0T";
        }

        /// <summary>
        /// Sleeps for 1sec, generates a random guess with range based on either the limit if it is the first guess or the remaining possible range after previous guesses. Outputs the guess.
        /// </summary>
        /// <returns>The current guess.</returns>
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
