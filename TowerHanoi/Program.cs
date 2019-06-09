using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerHanoi
{
    class Program
    {
        public static Dictionary<string, Stack<int>> Board = new Dictionary<string, Stack<int>>(); // Dictionary
        public static string StartingPeg, EndingPeg; // Player will choose to move a disk from StartingPeg to EndingPeg
        public static Stack<int> rowA = new Stack<int>(); // Peg A
        public static Stack<int> rowB = new Stack<int>(); // Peg B
        public static Stack<int> rowC = new Stack<int>(); // Peg C
        public static int moves = 0; // Keep track of how many moves the player makes
        static void Main(string[] args)
        {
            int i = 4;
            while (i > 0)
            {
                rowA.Push(i);
                --i;
            }
            Board.Add("A:", rowA);
            Board.Add("B:", rowB);
            Board.Add("C:", rowC);
            while (GameLogic(StartingPeg, EndingPeg) == false)
            {
                Console.WriteLine("Moves - " + moves);
                Console.WriteLine(" ");
                PrintBoard();
                Console.WriteLine(" ");
                Console.WriteLine("Which row do you want to move the top piece from?");
                StartingPeg = Console.ReadLine().ToUpper();
                Console.WriteLine("Which row do you want to move the piece from " + StartingPeg + " to?");
                EndingPeg = Console.ReadLine().ToUpper();
            }
            PrintBoard();
            Console.Read();
        }
        public static void PrintBoard()
        {
            Console.WriteLine("Welcome to Towers of Hanoi!");
            Console.WriteLine(" ");
            Console.WriteLine("Instructions:");
            Console.WriteLine("The disks are labelled 1 to 4,");
            Console.WriteLine("with 1 being the smallest and 4 being the largest.");
            Console.WriteLine("Your goal is to move all of the disks from Peg A to Peg C,");
            Console.WriteLine("in the same order they are in now: 4 3 2 1");
            Console.WriteLine(" ");
            Console.WriteLine("Remember:");
            Console.WriteLine("**You cannot place a larger disk on top of a smaller disk**");
            Console.WriteLine(" ");
            foreach (KeyValuePair<string, Stack<int>> column in Board)
            {
                string colLabel = string.Empty;
                foreach (int disk in column.Value.Reverse())
                {
                    colLabel += disk + " ";
                }
                Console.WriteLine("{0}: {1}", column.Key[0], colLabel);
            }
            Console.WriteLine("");
        }
        public static bool GameLogic(string StartingPeg, string EndingPeg)
        {
            if (StartingPeg != null)
            {
                bool sameColumn = false;
                if (StartingPeg == EndingPeg)
                {
                    sameColumn = true;
                }
                if (sameColumn == false)
                {
                    if (LegalMove(StartingPeg, EndingPeg) == true)
                    {
                        if (Board[StartingPeg].Count() != 0)
                        {
                            Board[EndingPeg].Push(Board[StartingPeg].Pop());
                        }
                    }
                }
            }
            Console.Clear();
            return GameWon();
        }
        public static bool LegalMove(string StartingPeg, string EndingPeg) //Check if move is legal
        {
            if (Board[StartingPeg].Count() != 0 && Board[EndingPeg].Count() != 0)
            {
                if (Board[StartingPeg].Peek() < Board[EndingPeg].Peek())
                {
                    ++moves;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                ++moves;
                return true;
            }
        }
        public static bool GameWon() // Player wins game
        {
            if (Board["C"].Count() == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
