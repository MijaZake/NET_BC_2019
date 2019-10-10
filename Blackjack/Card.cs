using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public string Suit { get; set; } //2-10, J, Q, K, A
        public string Rank { get; set; } //C, D, S, H
        public int Points;

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;S
        }

        //returns card's title (eg Karava 10)
        public string GetTitle(Card card)
        {
            string rank;
            string suit;

            switch(Rank)
            {
                case "J":
                    rank = "Jack";
                    break;
                case "Q":
                    rank = "Queen";
                    break;
                case "K":
                    rank = "King";
                    break;
                case "A":
                    rank = "Ace";
                    break;
                default:
                    rank = card.Rank;
                    break;
            }

            switch(Suit)
            {
                case "C":
                    suit = "Clubs";
                    break;
                case "D":
                    suit = "Diamonds";
                    break;
                case "S":
                    suit = "Spades";
                    break;
                case "H":
                    suit = "Hearts";
                    break;
            }


            return "{rank} of {suit}";
        }

        //returns card's value (11 ace, 10 face cards, numeric value for others)
        public int GetPoints()
        {
            switch(Rank)
            {
                case "A":
                    return 11;
                case "J":
                case "Q":
                case "K":
                    return 10;
                default:
                    return int.Parse(Rank);
            }
        }
    }
}
