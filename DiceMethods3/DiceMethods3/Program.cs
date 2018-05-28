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
            string choice = string.Empty;
            
            do
            {
                Lines();
                Console.WriteLine("Welcome to the Dice Roll game!");
                Console.WriteLine("Do you want to toll the dics?");
                Lines();
                choice = Console.ReadLine().ToLower();
                if (choice == "yes")
                {
                    int die = 0;
                    die = rollGenerator();
                    Console.WriteLine($"You rolled a {die}");
                }

                else if (choice == "no")
                {
                    Console.WriteLine("GAME OVER");
                }
                else if (choice != "yes" || choice != "no")
                {
                    Console.WriteLine("Please enter a Yes or No answer");
                }
            }
            while (choice != "no");
        }

        static void Lines()
        {
            Console.WriteLine("-------------------------------");
        }

        static int rollGenerator()
        {
            int die = 0;
            Random number = new Random();
            die = number.Next(1, 7);
            return die;
        }

    }
}
