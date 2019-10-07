using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    abstract class BasePlayer : IPlayer
    {
        public string Name;
        public int CurrentGuess;

        public BasePlayer()
        {
            Name = GetName();
        }

        public abstract string GetName();
        public abstract int GuessNumber();

        public virtual bool IsNumberGuessed(int number)
        {
                return number == CurrentGuess;
        }
    }
}
