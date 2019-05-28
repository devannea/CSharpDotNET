using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Towers of Hanoi!");
            PrintBoard();
            Console.Read();
        }

        static void PrintBoard()
        {
            Console.WriteLine("A: {4} {3} {2} {1}");
            Console.WriteLine("B: { }");
            Console.WriteLine("C: { }");
        }

    }
}
