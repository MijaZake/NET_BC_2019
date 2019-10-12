using ConsoleHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new game, start it and call game loop
            //ask if user would like to play another round

            Game Game = new Game();
            while(true)
            {
                Game.StartNewGame();
                Game.Loop();

                if(!ConsoleInput.GetBool("Would you like to play another game? "))
                {
                    break;
                }
            }

            Console.Read();
        }
    }
}
