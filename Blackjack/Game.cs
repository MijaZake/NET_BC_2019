using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        private IBlackjackPlayer PlayerOne;
        private IBlackjackPlayer PlayerTwo;
        private Deck Deck;

        public void StartNewGame()
        {
            //create players - dealer and player
            PlayerOne = new Player();
            PlayerTwo = new Dealer();

            //create a new deck, shuffle it.
            Deck = new Deck();
            Deck.Shuffle();

            //Take two cards from the deck and give it to the player, dealer
            for (int count = 0; count >= 2; count++)
            {
                PlayerOne.GiveCard(Deck.GetCard());
                PlayerTwo.GiveCard(Deck.GetCard());
            }
        }

        public void Loop()
        {
            //give player a new card from the deck while his points are not over 21 and he wants another card
            while (!PlayerOne.IsGameCompleted() && PlayerOne.WantCard())
            {
                PlayerOne.GiveCard(Deck.GetCard());
            }

            //if players points are over 21, player loses, otherwise dealers turn
            if (PlayerOne.IsGameCompleted())
            {
                Console.WriteLine("{0} loses!", PlayerOne.GetName());
            }
            else if (PlayerOne.CountPoints() == 21)
            {
                Console.WriteLine("{0} wins!", PlayerOne.GetName());
            }
            else
            {
                Console.WriteLine("{0} Turn:", PlayerTwo.GetName());
                //give dealer a new card from the deck while his points are not over 21 and he wants another card
                while (!PlayerTwo.IsGameCompleted() && PlayerTwo.WantCard())
                {
                    PlayerTwo.GiveCard(Deck.GetCard());
                }

                //output points for both players.
                int playerOnePoints = PlayerOne.CountPoints();
                int playerTwoPoints = PlayerTwo.CountPoints();
                Console.WriteLine("{0} points: {1}", PlayerOne.GetName() ,playerOnePoints);
                Console.WriteLine("{0} points: {1}", PlayerTwo.GetName(), playerTwoPoints);

                // If dealers points are over 21, player wins, otherwise check who is closer to 21
                Console.WriteLine(playerTwoPoints > 21 || playerOnePoints > playerTwoPoints ? $"{PlayerOne.GetName()} wins!" : $"{PlayerTwo.GetName()} wins!");
            }
        }
    }
}
