using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Dealer : BasePlayer
    {
        private const string DEALER_NAME = "Mr. Dealer";
        public override string GetName()
        {
            //return dealers name (constant)
            return DEALER_NAME;
        }

        public override bool WantCard()
        {
            //if dealer has at least 17 points, return false, otherwise true
            return CountPoints() <= 17;
        }
    }
}
