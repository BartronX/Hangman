using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public static class ConsoleUI
    {
        public static void PrintMainMenuHeader()
        {
            Console.WriteLine("*** Hangman ***");
        }

        public static void PrintMainMenuOptions()
        {
            Console.WriteLine("(1) Play");
            Console.WriteLine("(2) View Rules");
            Console.WriteLine("(3) Word List");
            Console.WriteLine("(4) Quit");
        }
    }
}
