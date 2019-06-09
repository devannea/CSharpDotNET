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
        public static Stack<int> rowA = new Stack<int>(); // Peg A
        public static Stack<int> rowB = new Stack<int>(); // Peg B
        public static Stack<int> rowC = new Stack<int>(); // Peg C
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
    }
}
