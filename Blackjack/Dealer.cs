using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Dealer : BasePlayer
    {
        public override string GetName()
        {
            return "Dealer";
        }

        public override bool WantCard()
        {
            Random r = new Random();
            int num = r.Next(1,2);

            switch(num)
            {
                case 1:
                    return true; 
                case 2:
                    return false;
                default:
                    return WantCard();
            }
        }
    }
}
