﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetApppInfo function to get info

            GreetUser(); // Ask for users name and greet

            while (true) 
            { 
                // Init correct number
                // int correctNumber = 7;

                // Create new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                    // Get users input
                {
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if(!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correcto number
                    if(guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mark Romig";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine("({0}: Version {1} by {2})", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game. . . ", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
