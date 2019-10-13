using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// Interface of main mechanics for players of the game - getting their name, guessing the number, checking if it was guessed.
    /// </summary>
    public interface IPlayer
    {
        int GuessNumber();
        bool IsNumberGuessed(int number);
        string GetName();
    }
}
