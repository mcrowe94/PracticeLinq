using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGamesList = new List<string>() { "Animal Crossing", "Elder Scrolls", "Grand Theft Auto" };
            var sortedByLength = videoGamesList.OrderBy(num => num.Length);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Video Games List");
            Console.WriteLine("");


            foreach(var game in videoGamesList)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Name : {game}\nLetters : {game.Length}");
                Console.WriteLine("---------------------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("Press Enter to see the title sorted by title length!");
            Console.ReadLine();

            foreach(var game in sortedByLength)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name : {game} has {game.Length} letters in the title! Cool!");
                Console.WriteLine("----------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
