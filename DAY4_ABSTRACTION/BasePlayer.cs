using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// Abstract class for all methods needed for all players of the game.
    /// </summary>
    public abstract class BasePlayer : IPlayer
    {
        protected string Name;
        protected int CurrentGuess;
        protected int NextGuess;

        /// <summary>
        /// Constructor of players of the game - gets player's name.
        /// </summary>
        public BasePlayer()
        {
            Name = GetName();
        }

        public abstract string GetName();
        public abstract int GuessNumber();

        /// <summary>
        /// Checks if player has guessed the right number or not, if not, checks and outputs if guess is smaller or bigger than the number.
        /// </summary>
        /// <param name="number">The right answer of the game.</param>
        /// <returns>Bool if the player has guessed the right number or not.</returns>
        public virtual bool IsNumberGuessed(int number)
        {
            if (number > CurrentGuess)
            {
                Console.WriteLine("Number is too small!");
                NextGuess = 1;
            }
            if (number < CurrentGuess)
            {
                Console.WriteLine("Number is too big!");
                NextGuess = -1;
            }

            return number == CurrentGuess;
        }
    }
}
