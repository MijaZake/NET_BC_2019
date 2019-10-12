using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace Blackjack
{
    public class Player : BasePlayer
    {
        public override string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            return ConsoleInput.GetText("Enter your name: ");
        }

        public override bool WantCard()
        {
            return ConsoleInput.GetBool("Another card? ");
        }

        public override void GiveCard(Card card)
        {
            base.GiveCard(card);
            Console.WriteLine("You received card: {0}", card.GetTitle());
            Console.WriteLine("Your points: {0}", CountPoints());
        }
    }
}
