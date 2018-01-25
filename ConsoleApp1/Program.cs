/* Author: Josh Freeman
 * Date: 1/25/2018
 * Program:
 * Description: allows the user to guess what number I am thinking of.
 */
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
            int userGuess = 0;
            int userNum1 = 0;
            int userNum2 = 0;
            int totalGuesses = 1;

            Console.WriteLine("Give me two numbers to start with.");
            userNum1 = Convert.ToInt32(Console.ReadLine());
            userNum2 = Convert.ToInt32(Console.ReadLine());

            int randNum = random.Next(userNum1, userNum2);

            Console.WriteLine("I am thinking of a number between " + userNum1 + " and " + userNum2 + " . Guess what it is.");

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
