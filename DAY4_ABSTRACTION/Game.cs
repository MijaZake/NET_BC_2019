using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Game
    {
        private int CurrentNumber;
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;

        public void StartNewGame()
        {
            CurrentNumber = new Random().Next(1, 500);
            PlayerOne = new User();
            PlayerTwo = new Robot();
        }

        public void Loop()
        {
            while(true)
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
