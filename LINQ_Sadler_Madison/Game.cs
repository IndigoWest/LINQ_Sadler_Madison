// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Linq namespace needed to use Console class
using System.Linq;
// System.Text namespace needed to use Console class
using System.Text;
// System.Threading.Tasks namespace needed to use Console class
using System.Threading.Tasks;

// My collection of classes for this project
namespace LINQ_Sadler_Madison
{
    // Creats a class called Game
    internal class Game
    {
        // Creates string parameter called Title with an automatic getter
        public string Title { get; }

        // Creates character parameter called Esrb with an automatic getter
        public char Esrb { get; }

        // Creates string parameter called Genre with an automatic getter
        public string Genre { get; }

        // Creates a constructor called Game that passes parameters: titleParam, esrbParam, and genreParam
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            // Assigns Title to titleParam
            Title = titleParam;
            // Assigns Esrb to esrbParam
            Esrb = esrbParam;
            // Assigns Genre to genreParam
            Genre = genreParam;
        }
    }
}
