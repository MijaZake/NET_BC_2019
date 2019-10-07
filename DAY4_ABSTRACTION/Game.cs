using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class Game
    {
        int CurrentNumber;
        IPlayer PlayerOne;
        IPlayer PlayerTwo;

        public void StartNewGame()
        {
            Random rnd = new Random();
            CurrentNumber = rnd.Next(1, 500);
            PlayerOne = new User();
            PlayerTwo = new Robot();
        }

        public void Loop()
        {
            while(true)
            {
                PlayerTurn(PlayerOne);
                if (PlayerOne.IsNumberGuessed(CurrentNumber))
                {
                    Console.WriteLine("Player 1 wins!");
                    break;
                }

                PlayerTurn(PlayerTwo);
                if (PlayerTwo.IsNumberGuessed(CurrentNumber))
                {
                    Console.WriteLine("Player 2 wins!");
                    break;
                }
            }
        }

        void PlayerTurn(IPlayer player)
        {
            player.GuessNumber();
        }
    }
}
