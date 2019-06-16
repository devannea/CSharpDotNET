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
            Console.WriteLine("Welcome to MasterMind the Game!");

        }
    }
    class MasterMind
    {
        // easiest way possible
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

            // Check if color1 is in correct position
            string[] guessArray = guess.Split(' ');
            if (guessArray[0] == color1) positionsCorrect++;
            // Check if color2 is in correct position
            if (guessArray[2] == color1) 
        }
    }
}
