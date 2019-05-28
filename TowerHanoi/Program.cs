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
            Start();
            PrintBoard();
            Console.Read();
        }

        static void Start()
        {
            PrintBoard();
            Console.WriteLine("Choose the disc you'd like to move first.");
            int discChoice = int.Parse(Console.ReadLine());
            if (discChoice != 1 && discChoice != 2 && discChoice != 3 && discChoice != 4)
            {
                Console.WriteLine("You have entered an incorrect response. Please check your input and try again.");
            }
            Console.WriteLine("You have selected " + discChoice);
        }

        static void PrintBoard()
        {
            Console.WriteLine("A: {4} {3} {2} {1}");
            Console.WriteLine("B: { }");
            Console.WriteLine("C: { }");
        }

    }
}
