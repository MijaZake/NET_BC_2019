using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player : BasePlayer
    {
        public override string GetName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }

        public override bool WantCard()
        {
            Console.Write("Draw another card? (y/n)");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid answer!");
                return WantCard();
            }
        }
    }
}
