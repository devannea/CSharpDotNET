using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("ToDoList");
            Console.WriteLine("Would you like to add an item (Yes/No)?");
            userInput = Console.ReadLine();
            Console.ReadLine();

            List<ToDoItem> ToDoList = new List<ToDoItem>();
            while (userInput != "no")
            {
                Console.WriteLine("Please enter a description for the item you want to add.");
                string description = Console.ReadLine();
                Console.WriteLine("Please enter a due date for the item you want to add (MM/DD/YY).");
                string dueDate = Console.ReadLine();
                Console.WriteLine("Please enter a priority rating for the item you want to add (High, Normal, Low).");
                string priority = Console.ReadLine();
                // instantiate
                ToDoItem myItem = new ToDoItem(description, dueDate, priority);
                // add item to ToDoList
                ToDoList.Add(myItem);
                Console.WriteLine("Would you like to add an item (Yes/No)?");
                userInput = Console.ReadLine();
            }
            foreach (ToDoItem item in ToDoList)
            {
                // print out list items
            }
            Console.ReadKey();
        }

        class ToDoItem
        {
            public String Description { get; set; }
            public String DueDate { get; set; }
            public String Priority { get; set; } // high, normal, or low

            public ToDoItem(string description, string dueDate, string priority)
            {
                Description = description;
                DueDate = dueDate;
                Priority = priority;
            }
        }
    }
}
