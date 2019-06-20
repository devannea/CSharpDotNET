using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Choose();
            Console.Read();
        }
        public static void Choose()
        {
            string[] firstCharArr = new string[] { "A", "D", "D", "E", "G", "J", "J", "J", "L", "L", "N", "O", "O", "O", "Q", "Q", "V", "V", "W", "X" };
            string[] secondCharArr = new string[] { "G", "G", "K", "O", "Q", "Q", "Q", "Q", "R", "R", "V", "W", "Y", "Z", "Z", "0", "6", "6", "8", "8" };
            string[] thirdCharArr = new string[] { "A", "A", "B", "G", "G", "G", "G", "M", "O", "R", "W", "W", "X", "X", "X", "Y", "Y", "0", "1", "1" };
            string[] fourthCharArr = new string[] { "D", "D", "D", "I", "J", "K", "K", "L", "L", "O", "P", "Q", "Q", "R", "R", "Y", "2", "6", "6", "9" };
            Random rand = new Random();
            int firstCharIndex = rand.Next(0, 20);
            int secondCharIndex = rand.Next(0, 20);
            int thirdCharIndex = rand.Next(0, 20);
            int fourthCharIndex = rand.Next(0, 20);
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"{firstCharArr[firstCharIndex]}{secondCharArr[secondCharIndex]}{thirdCharArr[thirdCharIndex]}{fourthCharArr[fourthCharIndex]}");
            }
        }
    }
}
