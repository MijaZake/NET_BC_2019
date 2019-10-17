using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// Contains all methods needed for a human player of the game.
    /// </summary>
    public class User : BasePlayer
    {
        /// <summary>
        /// If Name is empty, asks and gets the name of the user. If Name is not empty, returns Name.
        /// </summary>
        /// <returns>Name or function that gets name.</returns>
        public override string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }

            return ConsoleInput.GetText("Please enter your name: ");
        }

        /// <summary>
        /// Asks the user to input their guess and checks if the number is out of limits, throws exception if it is.
        /// </summary>
        /// <returns>The current guess that the user input.</returns>
        public override int GuessNumber()
        {
            CurrentGuess = ConsoleInput.GetInt("Enter a positive integer: ");
            if (CurrentGuess > 500 || CurrentGuess < 1)
            {
                throw new LimitException("Number out of limits! [1-500]");
            }

            return CurrentGuess;
        }
    }
}
