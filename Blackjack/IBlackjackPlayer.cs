using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    interface IBlackjackPlayer
    {
        //returns players name
        string GetName();
        //returns players cards in hand
        List<Card> GetCards();
        //counts total points of player's cards
        //if over 21 and player has ace, remove 10 for each ace
        //until under 21 or no more aces
        int CountPoints();
        //checks if players points are over 21, otherwise - false
        bool IsGameCompleted();
        //checks if player wants another card
        bool WantCard();
        //player receives a new card from the deck, adds to hand
        void GiveCard(Card card);
    }
}
