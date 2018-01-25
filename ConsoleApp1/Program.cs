using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randNum = random.Next(0, 100);
            int userGuess = 0;
            int totalGuesses = 1;

            Console.WriteLine("I am thinking of a number between 0 and 100.  Guess what it is.");

            while (userGuess != randNum)
            {
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess < randNum)
                {
                    Console.WriteLine("That's too low. Guess again.");
                    totalGuesses++;
                }
                else if (userGuess > randNum)
                {
                    Console.WriteLine("That's too high. Guess again.");
                    totalGuesses++;
                }
            }
            Console.WriteLine("That's it! The answer was " + randNum + ". It took you " + totalGuesses + " guesses to guess the correct number.");

            Console.ReadLine();
        }
    }
}
