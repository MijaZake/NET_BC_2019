using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        List<Card> CardDeck;
        string[] suits = new[] {"C", "S", "D", "H" };
        string[] ranks = new[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };

        //creates a new list of cards (List<Card>)
        //fills list with all 52 cards (4 suits, 13 ranks)
        public Deck()
        {
            CardDeck = new List<Card>();
            foreach(string s in suits)
            {
                foreach(string r in ranks)
                {
                    CardDeck.Add(new Card(s,r));
                }
            }
        }

        //randomly orders (shuffles) the list of cards
        public void Shuffle()
        {
            Random r = new Random();
            CardDeck = CardDeck.OrderBy(c => r.Next()).ToList();
        }

        //takes the last card from the list, removes, returns it
        public Card GetCard()
        {
            Card card = CardDeck.Last();
            CardDeck.Remove(card);
            return card;
        }
    }
}
