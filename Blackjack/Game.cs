using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        public void StartNewGame()
        {
            Console.WriteLine("-BLACKJACK-");
            Player player = new Player();
            Dealer dealer = new Dealer();
            Deck deck = new Deck();
            player.GiveCard();
        }

        public void Loop()
        {

        }
    }
}
