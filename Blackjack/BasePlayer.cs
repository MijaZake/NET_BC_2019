using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public abstract class BasePlayer : IBlackjackPlayer
    {
        protected string Name { get; set; }
        protected List<Card> Cards { get; set; }

        public BasePlayer()
        {
            Cards = new List<Card>();
            Name = GetName();
        }

        //returns players cards in hand
        public List<Card> GetCards()
        {
            return Cards;
        }
        //counts total points of player's cards
        //if over 21 and player has ace, remove 10 for each ace
        //until under 21 or no more aces
        public int CountPoints()
        {
            int sum = Cards.Sum(c => c.GetPoints());

            if(sum > 21)
            {
                int aceCount = Cards.Count(c => c.GetPoints() == 11);
                while(aceCount > 0 && sum > 21)
                {
                    sum -= 10;
                    aceCount -= 1;
                }
            }

            return sum;
        }
        //checks if players points are over 21, otherwise - false
        public bool IsGameCompleted()
        {
            return CountPoints() > 21;
        }
        //player receives a new card from the deck, adds to hand
        public void GiveCard(Card card)
        {
            Cards.Add(card);
        }

        public abstract string GetName();
        public abstract bool WantCard();
    }
}
}
