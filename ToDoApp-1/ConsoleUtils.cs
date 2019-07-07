using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp_1
{
    class ConsoleUtils
    {
        public static void DisplayMenu()
        {
            Console.WriteLine();
            DisplayHeader("Menu");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 List pending items");
            Console.WriteLine("2 List done items");
            Console.WriteLine("3 List all items");
            Console.WriteLine("4 Mark done");
            Console.WriteLine("5 Add item");
            Console.WriteLine("6 Delete item");
            Console.WriteLine("7 Exit");
        }

        public static int GetCommand()
        {
            string input = Console.ReadLine();

            bool succeeded = int.TryParse(input, out int command);
            if (!succeeded)
            {
                Console.WriteLine("Invalid input; try again.");
                return 0;
            }

            if (command > 7)
            {
                Console.WriteLine("Invalid input; try again.");
                return 0;
            }

            return command;
        }

        public static void DisplayHeader(string headerText)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine(headerText.ToUpper());
            Console.WriteLine("***********************************************");
        }

        public static void DisplayItem(ToDoItem item)
        {
            string statusDescription = item.Status ? "DONE" : "PENDING";
            Console.WriteLine($"Id #{item.Id}: {item.Description} -- {statusDescription}");
        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static int ReadInt()
        {
            string input = Console.ReadLine();

            bool succeeded = int.TryParse(input, out int output);
            if (!succeeded)
            {
                Console.WriteLine("Invalid input; try again.");
                return 0;
            }

            return output;
        }

        public static int RequestId(string message)
        {
            ConsoleUtils.WriteMessage(message);
            int id = ConsoleUtils.ReadInt();
            return id;
        }
    }
}
