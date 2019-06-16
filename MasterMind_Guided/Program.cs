using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind_Guided
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterMind.play();
            Console.Read();
        }
    }
    class MasterMind
    {
        static string[] colors = new string[] { "red", "yellow", "blue" };
        static string color1;
        static string color2;
        // Computer will choose two colors from the colors array at random
        static void pickColors() // Method to pick colors
        {
            var rand = new Random();
            var colorIdx1 = rand.Next(0, 3);
            var colorIdx2 = rand.Next(0, 3);
            color1 = colors[colorIdx1];
            color2 = colors[colorIdx2];
        }
        // Evaluate guess and provide hint
        static bool checkGuess(string guess)
        {
            int colorsCorrect = 0;
            int positionsCorrect = 0;
            // Check if color1 is contained in guess
            if (guess.Contains(color1)) colorsCorrect++;

            // Check if color2 is contained in guess
            if (guess.Contains(color2)) colorsCorrect++;

            string[] guessArray = guess.Split(' ');

            // Check if color1 is in correct position
            if (guessArray[0] == color1) positionsCorrect++;
            
            // Check if color2 is in correct position
            if (guessArray[1] == color2) positionsCorrect++;
            
            // Check if entire guess is correct
            if (positionsCorrect == 2 && colorsCorrect == 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Your hint is {colorsCorrect}-{positionsCorrect}");
                return false;
            }
        }

        // Loop until checkGuess returns true
        public static void play()
        {
            pickColors();
            Console.WriteLine("Welcome to MasterMind the Game!");
            Console.WriteLine("Game Instructions:");
            Console.WriteLine("The computer will choose 2 colors at random: red, yellow, or blue.");
            Console.WriteLine("The computer can choose the same color twice.");
            Console.WriteLine("You will try to guess the colors chosen.");
            Console.WriteLine("");
            while(true)
            {
                Console.WriteLine("Please enter your guess:");
                var userGuess = Console.ReadLine();
                if (checkGuess(userGuess))
                {
                    Console.WriteLine("You won! Good job!");
                    break;
                }
            }
        }
    }
}
