using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Game game = new Game();
                game.StartNewGame();
                game.Loop();
            }
            catch (LimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error! {0}", ex.Message);
            }

            Console.Read();
        }
    }
}
