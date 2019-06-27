using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsContext context = new StudentsContext();
            context.Database.EnsureCreated();
            Console.WriteLine("Enter Student full name");
            String fullName = Console.ReadLine();
            String[] parts = fullName.Split();
            if (parts.Length == 2)
            {
                Students newStudent = new Students(parts[0], parts[1]);
                //context.Students.Add(newStudent);
                context.SaveChanges();
                Console.WriteLine("Added the student.");
            }
            else
            {
                Console.WriteLine("Invalid full name, did not add student");
            }
            Console.WriteLine("The Current List of students are: ");
            //foreach (Students s in context.Students)
            //{
            //    Console.WriteLine("{0} - {1} {2}",
            //         s.Id, s.FirstName, s.LastName);
            //}
        }
    }
}
