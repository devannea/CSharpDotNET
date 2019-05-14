using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            ChooseHand();
        }

        public static void ChooseHand()
        {
            //Initial score
            int PlayerScore = 0;
            int ComputerScore = 0;

            while(true)
            {
                Console.WriteLine("Choose your hand."); //Player chooses hand
                Console.WriteLine("Select rock, paper, or scissors.");
                string ChosenHand = Console.ReadLine().ToLower();
                Console.WriteLine("You chose " + ChosenHand);
                Random generator = new Random(); //Computer chooses a random number between 0 and 2
                int RandomNumber = generator.Next(0, 3);
                string RandomHand = RandomNumber.ToString(); //Convert int to string || Convert number to hand
                if (RandomNumber == 0) //0 is rock
                {
                    RandomHand = "rock";
                }
                if (RandomNumber == 1) //1 is paper
                {
                    RandomHand = "paper";
                }
                if (RandomNumber == 2) //2 is scissors
                {
                    RandomHand = "scissors";
                }
                Console.WriteLine("The computer chose " + RandomHand);
                //Winner is chosen
                string Win = "You win!";
                string Lose = "Computer wins.";
                string Tie = "You tied.";
                //Player chose rock
                if ((ChosenHand == "rock") && (RandomHand == "rock"))
                {
                    Console.WriteLine(Tie);
                }
                if ((ChosenHand == "rock") && (RandomHand == "paper"))
                {
                    Console.WriteLine(Lose);
                    ++ComputerScore;
                }
                if ((ChosenHand == "rock") && (RandomHand == "scissors"))
                {
                    Console.WriteLine(Win);
                    ++PlayerScore;
                }
                //Player chose paper
                if ((ChosenHand == "paper") && (RandomHand == "rock"))
                {
                    Console.WriteLine(Win);
                    ++PlayerScore;
                }
                if ((ChosenHand == "paper") && (RandomHand == "paper"))
                {
                    Console.WriteLine(Tie);
                }
                if ((ChosenHand == "paper") && (RandomHand == "scissors"))
                {
                    Console.WriteLine(Lose);
                    ++ComputerScore;
                }
                //Player chose scissors
                if ((ChosenHand == "scissors") && (RandomHand == "rock"))
                {
                    Console.WriteLine(Lose);
                    ++ComputerScore;
                }
                if ((ChosenHand == "scissors") && (RandomHand == "paper"))
                {
                    Console.WriteLine(Win);
                    ++PlayerScore;
                }
                if ((ChosenHand == "scissors") && (RandomHand == "scissors"))
                {
                    Console.WriteLine(Tie);
                }
                //Show score
                Console.WriteLine("You have won " + PlayerScore + " rounds. The computer has won " + ComputerScore + " rounds.");
                //Play again option
                Console.WriteLine("Play again? Enter Yes or No.");
                if (!Console.ReadLine().StartsWith("Y", StringComparison.OrdinalIgnoreCase)) break;
            }
        }

    }
}
