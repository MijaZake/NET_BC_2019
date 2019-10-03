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

        void StartNewGame()
        {
            //Random rnd = new Random();
            //int[] numbers = { };
        }

        void Loop()
        {
            while(true)
            {
                Console.Write("Guess the number: ");
                CurrentNumber = int.Parse(Console.ReadLine());
            }
        }

        void PlayerTurn(IPlayer player)
        {

        }
    }
}
