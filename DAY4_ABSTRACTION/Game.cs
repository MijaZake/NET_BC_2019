using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// Main game class that contains the main game mechanics - starting a new game and player turns.
    /// </summary>
    public class Game
    {
        private int CurrentNumber;
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;

        /// <summary>
        /// Starts new game - generates a random number to guess and initiates two players.
        /// </summary>
        public void StartNewGame()
        {
            CurrentNumber = new Random().Next(1, 500);
            PlayerOne = new User();
            PlayerTwo = new Robot();
        }

        /// <summary>
        /// Loops between player turns.
        /// </summary>
        public void Loop()
        {
            while (true)
            {
                Console.Write("P1: ");
                if (PlayerTurn(PlayerOne))
                {
                    break;
                }

                Console.Write("P2: ");
                if (PlayerTurn(PlayerTwo))
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Executes a player's turn - guessing the number, checking if the number is correct and ending the game if it is.
        /// </summary>
        /// <param name="player">The player who is doing the turn.</param>
        /// <returns>Bool if the number is guessed or not.</returns>
        private bool PlayerTurn(IPlayer player)
        {
            player.GuessNumber();
            bool isGuessed = player.IsNumberGuessed(CurrentNumber);

            if (isGuessed)
            {
                Console.WriteLine("Player {0} wins!", player.GetName());
            }

            return isGuessed;
        }
    }
}

