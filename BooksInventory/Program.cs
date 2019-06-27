using System;

namespace BooksInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            BookContext context = new BookContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Enter the title and author of the book.");
            Console.WriteLine("Separate using a comma and a space.");
            Console.WriteLine("Example: Title, Author");
            Console.WriteLine(' ');
            String bookDetails = Console.ReadLine();

            String[] parts = bookDetails.Split(", ");
            if (parts.Length == 2)
            {
                Books newBook = new Books(parts[0], parts[1]);

                context.Books.Add(newBook);

                context.SaveChanges();
                Console.WriteLine("Added the book.");
            }
            else
            {
                Console.WriteLine("Invalid entry, did not add book");
            }

            Console.WriteLine("Current list of books:");
            foreach (Books s in context.Books)
            {
                Console.WriteLine("{0} - {1} {2}",
                     s.Id, s.Title, s.Author);
            }
        }
    }
}
