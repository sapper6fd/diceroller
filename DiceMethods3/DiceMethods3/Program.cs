using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            startGame();
        }

        static void startGame()
        {
            // Declare start game question
            string choice = string.Empty;
            
            do
            {
                // Display intro message to user
                Lines();
                Console.WriteLine("Welcome to the Dice Roll game!");
                Console.WriteLine("Do you want to toll the dics?");
                Lines();
                // Get users decision to start the game
                choice = Console.ReadLine().ToLower();
                if (choice == "yes")
                {
                    // Display the result of the dice being rolled.
                    int die = 0;
                    die = rollGenerator();
                    Console.WriteLine($"You rolled a {die}");
                }
                // End the game at the users request
                else if (choice == "no")
                {
                    Console.WriteLine("GAME OVER");
                }
                // Inform user of an invalid option to start or end the game
                else if (choice != "yes" || choice != "no")
                {
                    Console.WriteLine("Please enter a Yes or No answer");
                }
            }
            while (choice != "no");
        }

        static void Lines()
        {
            // Add seperating lines to make the game easier to read
            Console.WriteLine("-------------------------------");
        }

        // Generate a random number from 1, up to and including 6, each time the dice is rolled.
        static int rollGenerator()
        {
            int die = 0;
            Random number = new Random();
            die = number.Next(1, 7);
            return die;
        }

    }
}
