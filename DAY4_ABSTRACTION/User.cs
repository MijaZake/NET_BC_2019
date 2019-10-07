using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class User : BasePlayer
    {
        public override string GetName()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();

            return input;
        }

        public override int GuessNumber()
        {
            Console.Write("Enter a positive integer: ");
            CurrentGuess = int.Parse(Console.ReadLine());

            return CurrentGuess;
        }
    }
}
