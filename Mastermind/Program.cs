using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {

        static string[] trueColor = new string[3];
        static string[] colorArray = new string[] { "red", "yellow", "blue" };
        static bool gameOver = false;

        static void Main(string[] args)
        {
            Console.WriteLine("> Welcome to Mastermind!");
            Start();
            Console.Read();
        }

        static void Start()
        {
            // Generate random colors
            Random generator = new Random();

            // Create loop to generate random colors
            int randomIndex = generator.Next(0, 3); // Computer chooses a random number between 0 and 2
            for (int i = 0; i < 1; i++)
            {
                Console.Write(trueColor[0] = colorArray[randomIndex] + " ");
                randomIndex = generator.Next(0, 3);
                Console.WriteLine(trueColor[1] = colorArray[randomIndex]);
            }
            // Repeat if the game isn't over
            while (gameOver == false)
            {
                // Ask Player to enter  guess
                Console.WriteLine("> Please enter your guess: ");
                string input = Console.ReadLine().ToLower(); // This takes the Player's input and sets it as a string variable
                string[] guess = input.Split(' '); // This will split the Player's input anywhere a space occurs
                // Check guess
                // If Player's input is not a color from colorArray or is misspelled
                if (guess[0] != "red" && guess[0] != "yellow" && guess[0] != "blue" && guess[1] != "red" && guess[1] != "yellow" && guess[1] != "blue")
                {
                    Console.WriteLine("> You have entered an incorrect response. Please check your input and try again.");
                    continue;
                }
                // If Player guesses both colors correctly in the correct positions
                if (guess[0] == trueColor[0] && guess[1] == trueColor[1])
                {
                    Console.WriteLine("> You win!");
                    gameOver = true; // This will cause the loop to finish
                }
                if (guess[0] != trueColor[0] && guess[0] !=trueColor[1] && guess[1] != trueColor[0] && guess[1] != trueColor[1])
                {
                    Console.WriteLine("> Hint: 0-0"); // 0-0 means the Player guessed the colors incorrectly and in the incorrect positions
                    continue; // This will cause the loop to continue
                }
                if (trueColor[0] == trueColor[1]) // If the two colors randomly generated are the same
                {
                    if (guess[0] == trueColor[0] && guess[0] != trueColor[1] && guess[1] != trueColor[0] && guess[1] != trueColor[1])
                    {
                        Console.WriteLine("> Hint: 0-1"); // Player guessed the first trueColor in the correct position
                        goto Start;
                    }
                    if (guess[0] != trueColor[0] && guess[0] != trueColor[1] && guess[1] != trueColor[0] && guess[1] == trueColor[1])
                    {
                        Console.WriteLine("> Hint: 0-1"); // Player guessed the second trueColor in the correct position
                        goto Start;
                    }
                }
                if (trueColor[0] != trueColor[1]) // If the two colors randomly generated are not the same
                {
                    if (guess[0] != trueColor[0] && guess[1] == trueColor[0] && guess[0] != trueColor[1] && guess[1] != trueColor[1])
                    {
                        Console.WriteLine("> Hint: 1-0"); // Player guessed the first trueColor in wrong position
                        goto Start;
                    }
                    if (guess[0] != trueColor[0] && guess[1] != trueColor[0] && guess[0] == trueColor[1] && guess[1] != trueColor[1])
                    {
                        Console.WriteLine("> Hint: 1-0"); // Player guessed the second trueColor in wrong position
                        goto Start;
                    }
                    if (guess[0] == trueColor[0] && guess[1] != trueColor[0] && guess[0] != trueColor[1] && guess[1] != trueColor[1])
                    {
                        Console.WriteLine("> Hint: 0-1"); // Player guessed the first trueColor in the correct position
                        goto Start;
                    }
                    if (guess[0] != trueColor[0] && guess[1] != trueColor[0] && guess[0] != trueColor[1] && guess[1] == trueColor[1])
                    {
                        Console.WriteLine("> Hint: 0-1"); // Player guessed the second trueColor in the correct position
                        goto Start;
                    }
                    if (guess[0] != trueColor[0] && guess[1] == trueColor[0] && guess[0] == trueColor[1] && guess[1] != trueColor[1])
                    {
                        Console.WriteLine("> Hint: 2-0"); // Player guessed both trueColors but in the wrong position
                        goto Start;
                    }
                }
            } // End of loop

            Console.WriteLine("> Do you want to play again? Enter Yes or No.");
            string playAgain = Console.ReadLine().ToLower();
            while (true)
            { // Loop start for play again options
                if (playAgain == "yes")
                {
                    Start(); // Game starts over again
                }
                if (playAgain == "no")
                {
                    Environment.Exit(0); // Application closes
                }
                else
                {
                    Console.WriteLine("> You did not enter a proper response. Please enter Yes or No.");
                    continue; // Goes to start of loop to get proper response
                }
            } // End of loop for play again options
        }
    }
}
