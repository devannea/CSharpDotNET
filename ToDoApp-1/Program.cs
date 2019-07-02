using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemContext context = new ItemContext();
            context.Database.EnsureCreated();
            Console.WriteLine("Enter the task description and completion status.");
            Console.WriteLine("If the task is complete, then the completion status is 'done',");
            Console.WriteLine("If the task is incomplete, then the completion status is 'not done'.");
            Console.WriteLine("Use a comma and a space to separate these two,");
            Console.WriteLine("Example: task description, done");
            string taskDetails = Console.ReadLine();
            string[] parts = taskDetails.Split(", ");
            ToDoItem newToDoItem = new ToDoItem(parts[0], parts[1]);
            if (parts.Length == 2)
            {
                ToDoItem newToDoItem = new ToDoItem(parts[0], parts[1]);
                context.ToDoItem.Add(newToDoItem);
                context.SaveChanges();
                Console.WriteLine("Added the task.");
            }
            else
            {
                Console.WriteLine("Invalid entry, did not add task");
            }
        }   
    }
}
