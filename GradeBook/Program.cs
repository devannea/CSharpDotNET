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
            Console.WriteLine("Welcome to the GradeBook!");
            Start();
            Console.Read();
        }

        static void Start()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("Please enter the name of the student, or say 'Quit' to evaluate the grades of the student(s).");
                string studentName = Console.ReadLine();
                if (studentName != "quit")
                {
                    Console.WriteLine("Please enter the grades of the student. Round to the nearest integer. Do not use decimals.");
                    Console.WriteLine("Separate the grades using a space. Do not use commas or any other punctuation.");
                    Console.WriteLine("Example: 91 84 79 100");
                    string studentGrades = Console.ReadLine();
                    myDict.Add(studentName, studentGrades);
                }
                if (studentName == "quit")
                {
                    string studentName;
                    string studentGrades;
                    string[] gradeArray;
                    int[] iGrades;
                    foreach (var i in studentGrades.Keys)
                    {
                        studentName = i;
                        studentGrades = studentGrades[i];
                        gradeArray = studentGrades.Split(' ');
                        iGrades = Array.ConvertAll(gradeArray, int.Parse);
                    }
                }
            }
        }
    }
}
