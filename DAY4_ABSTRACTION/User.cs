using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace DAY4_ABSTRACTION
{
    public class User : BasePlayer
    {
        public override string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            
            return ConsoleInput.GetText("Please enter your name: ");
        }

        public override int GuessNumber()
        {
            CurrentGuess = ConsoleInput.GetInt("Enter a positive integer: ");
            if (CurrentGuess > 500 || CurrentGuess < 1)
            {
                throw new LimitException("Number out of limits! [1-500]");
            }

            return CurrentGuess;
        }
    }
}
