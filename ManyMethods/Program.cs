using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Hello()
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name + "!");
        }

        public static void Addition()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of the two numbers you entered is " + sum);
        }

        public static void CatDog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            string preference = Console.ReadLine().ToLower();
            if (preference == "cats")
            {
                Console.WriteLine("Meow!");
                Console.ReadLine();
            }
            if (preference == "dogs")
            {
                Console.WriteLine("Woof!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sucks to be you, I guess.");
                Console.ReadLine();
            }
        }

        public static void OddEven()
        {
            int num;
            Console.WriteLine("Please enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number you entered is even.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number you entered is odd.");
                Console.ReadLine();
            }
        }

        public static void Inches()
        {
            Console.WriteLine("Please enter your height in feet: ");
            int feet = int.Parse(Console.ReadLine());
            int inches = feet * 12;
            Console.WriteLine("Your height in inches is " + inches);
        }

        public static void Echo()
        {
            Console.WriteLine("Pretend that you are in a cave. Every word you say has an echo. Enter a word: ");
            string echo1 = Console.ReadLine().ToUpper();
            string echo2 = echo1.ToLower();
            Console.WriteLine(echo1);
            Console.WriteLine(echo2);
            Console.WriteLine(echo2);
        }

        public static void KiloGram()
        {
            Console.WriteLine("Please enter your weight in pounds: ");
            double pounds = int.Parse(Console.ReadLine());
            double kilograms = pounds * 0.454;
            Console.WriteLine("Your weight in kilograms is " + kilograms);
        }

        public static void Date()
        {
            Console.WriteLine("The current date and time is: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }

        public static void Age()
        {
            Console.WriteLine("Please enter your birthyear.");
            int birthyear = int.Parse(Console.ReadLine());
            string today = DateTtime
            int age = 2019 - birthyear;
            Console.WriteLine("You are " + age + " years old.");
        }

        public static void Guess()
        {
            Console.WriteLine("Guess the word I am thinking of. :)");
            string answer = Console.ReadLine().ToLower().Replace(" ", string.Empty);
            if (answer == "csharp")
            {
                Console.WriteLine("Correct! :D");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong! >:C");
                Console.ReadLine();
            }
        }

    }
}
