using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// Exception for the limit of the guesses.
    /// </summary>
    class LimitException : Exception
    {
        public LimitException(string message) : base(message)
        {
                
        }
    }
}
