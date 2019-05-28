using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> Welcome to Mastermind!");
            Start();
            Console.Read();
        }

        static void Start()
        {
            // 1. Generate random colors
            Random generator = new Random();
            int firstNumber = generator.Next(0, 3); // Computer chooses a random number between 0 and 2
            int secondNumber = generator.Next(0, 3); // Same as ^
            string firstColor = firstNumber.ToString(); // Convert int to string || Convert random number to a random color
            string secondColor = secondNumber.ToString();
            if (firstNumber == 0) // 0 becomes red
            {
                firstColor = "red";
            }
            if (firstNumber == 1) // 1 becomes yellow
            {
                firstColor = "yellow";
            }
            if (firstNumber == 2) // 2 becomes blue
            {
                firstColor = "blue";
            }
            if (secondNumber == 0) // 0 becomes red
            {
                secondColor = "red";
            }
            if (secondNumber == 1) // 1 becomes yellow
            {
                secondColor = "yellow";
            }
            if (secondNumber == 2) // 2 becomes blue
            {
                secondColor = "blue";
            }
            /* Console.WriteLine(firstColor + " " + secondColor);
               Used this line to make sure that Random() was working
               Random() successfully generates two random colors
            */
            // 2. Player guesses random colors
            while (true)
            {   // loop start
                Console.WriteLine("> Please enter your guess: ");
                string guess = Console.ReadLine().ToLower(); // Player's guess
                string[] words = guess.Split(' '); // Splits guess where space is
                string firstGuess = words[0]; // first word becomes firstGuess
                string secondGuess = words[1]; // second word becomes secondGuess
                /* Console.WriteLine("The first color you guessed was " + firstGuess + " and the second color you guessed was " + secondGuess + ".");
                   Used this to make sure that the string guess was split into two variables - firstGuess and secondGuess */
                string[] colorArray = { "red", "yellow", "blue" };
                if (firstGuess != "red" && firstGuess != "yellow" && firstGuess != "blue" && secondGuess != "red" && secondGuess != "yellow" && secondGuess != "blue")
                {
                    Console.WriteLine("> You have entered an incorrect response. You can only guess red, yellow, or blue.");
                    continue;
                } // This will prevent the player from entering anything that is not red, yellow, or blue
                // Computer generates two colors, player guess both incorrectly
                if (firstColor != firstGuess && firstColor != secondGuess && secondColor != firstGuess && secondColor != secondGuess)
                {
                    Console.WriteLine("> Hint: 0-0");
                    continue;
                }
                // Computer generates two colors that are the same, player guesses the first one correctly in the correct position
                if (firstColor == secondColor && firstColor == firstGuess && firstGuess != secondGuess && secondColor != firstGuess && secondColor != secondGuess)
                {
                    Console.WriteLine("> Hint: 0-1");
                    continue;
                }
                // Computer generates two colors that are the same, player guesses the second one correctly in the correct position
                if (firstColor == secondColor && firstColor != firstGuess && firstColor != secondGuess && secondColor != firstGuess && secondColor == secondGuess)
                {
                    Console.WriteLine("> Hint: 0-1");
                    continue;
                }
                // Computer generates two colors that are not the same, player guesses the first one correctly in the wrong position
                if (firstColor != secondColor && firstColor != firstGuess && firstColor == secondGuess && secondColor != firstGuess && secondColor != secondGuess)
                {
                    Console.WriteLine("> Hint: 1-0");
                    continue;
                }
                // Computer generates two colors that are not the same, player guesses the second one correctly in the wrong position
                if (firstColor != secondColor && firstColor != firstGuess && firstColor != secondGuess && secondColor == firstGuess && secondColor != secondGuess)
                {
                    Console.WriteLine("> Hint: 1-0");
                    continue;
                }
                // Computer generates two colors that are not the same, player guesses the first one correctly in the correct position
                if (firstColor != secondColor && firstColor == firstGuess && firstColor != secondGuess && secondColor != firstGuess && secondColor != secondGuess)
                {
                    Console.WriteLine("> Hint: 0-1");
                    continue;
                }
                // Computer generates two colors that are not the same, player guesses the second one correctly in the correct position
                if (firstColor != secondColor && firstColor != firstGuess && firstColor != secondGuess && secondColor != firstGuess && secondColor == secondGuess)
                {
                    Console.WriteLine("> Hint: 0-1");
                    continue;
                }
                // Computer generates two colors that are not the same, player guesses both colors correctly in the wrong positions
                if (firstColor != secondColor && firstColor != firstGuess && firstColor == secondGuess && secondColor == firstGuess && secondColor != secondGuess)
                {
                    Console.WriteLine("> Hint: 2-0");
                    continue;
                }
                // Player guesses both colors correctly
                if (firstColor == firstGuess && secondColor == secondGuess)
                {
                    Console.WriteLine("> You won! :D");
                    Console.WriteLine("> Do you want to play again? Enter Yes or No.");
                    string playAgain = Console.ReadLine().ToLower();
                    while (true)
                    { // loop start for play again options
                        if (playAgain == "yes")
                        {
                            Start(); // game starts over again
                        }
                        if (playAgain == "no")
                        {
                            Environment.Exit(0); // application closes
                        }
                        else
                        {
                            Console.WriteLine("> You did not enter a proper response. Please enter Yes or No.");
                            continue; // goes to start of loop to get proper response
                        }
                    } // loop end for play again options
                }
            } // loop end
        }        
    }
}
