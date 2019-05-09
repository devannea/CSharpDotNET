using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {
        PigLatin();
        }

        // pig latin function goes here
        public static void PigLatin()
        {
            Console.WriteLine("Please enter a word or phrase that you would like to have translated to PigLatin.");
            string english = Console.ReadLine();
            string piglatin = english;
            Console.WriteLine("Translation: " + piglatin);
            Console.ReadLine();
        }

    }
}
