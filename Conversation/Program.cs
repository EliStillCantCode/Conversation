using System;
using static System.Console;

namespace Conversation
{
    static class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.DarkGray;
            BackgroundColor = ConsoleColor.Black;
            
            WriteLine("In a time, long long ago: there was a brave knight called...");
            ReadLine();
            WriteLine("...who had just finished a daring mission by the King to slay the mighty...");
            ReadLine();
            WriteLine("And so it was dead! After all these treacherous years!\nOur knight decided to head down the pub to get a drink.\nWhile he was there; he met a...");
            ReadLine();
            WriteLine("...who offered him a pint of...");
            ReadLine();
            WriteLine("'Ah! I can't turn down a proposal of such goods!' The knight exclaimed.\nThe bartender tried to warn him that he was being too loud but it was too late!");
            WriteLine("\n[Press ENTER to continue]");
            ReadLine();

            ForegroundColor = ConsoleColor.Red;
            WriteLine("");
            WriteLine("The knight's head was already gone.");
            
            ReadKey();
        }
    }
}