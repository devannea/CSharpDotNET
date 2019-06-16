using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GradeBook");
            Start();
            Console.Read();
        }

        static void Start()
        {
            Dictionary<string, string> gradebook = new Dictionary<string, string>();
            while (true) // Start of loop
            {
                Console.WriteLine("Please enter the name of the student, or say 'Done' to evaluate the grades of the student(s).");
                string nameInput = Console.ReadLine();
                if (nameInput.ToLower() != "done") // User entered a name
                {
                    Console.WriteLine("Please enter the grades of the student. Round to the nearest whole number integer. Do not use decimals.");
                    Console.WriteLine("Separate the grades using a space. Do not use commas or any other punctuation.");
                    Console.WriteLine("");
                    string gradeInput = Console.ReadLine();
                    gradebook.Add(nameInput, gradeInput);
                }
                else
                {
                    break;
                }
            } // End of loop
            foreach (var key in gradebook.Keys)
            {
                int[] gradeArray = Array.ConvertAll<string, int>(gradebook[key].Split(), Convert.ToInt32);
                double gradeAverage = gradeArray.Average(); // LINQ
                int gradeLowest = gradeArray.Min(); // LINQ
                int gradeHighest = gradeArray.Max(); // LINQ
                Console.WriteLine(" ");
                Console.WriteLine("Student: " + key);
                Console.WriteLine("Grade Average: " + Math.Round(gradeAverage, 2, MidpointRounding.AwayFromZero));
                Console.WriteLine("Lowest Grade: " + gradeLowest);
                Console.WriteLine("Highest Grade: " + gradeHighest);
            }
        }
    }
}
