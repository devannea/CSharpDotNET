using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BooksInventory
{
    class BookContext : DbContext
    {
        public DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "books.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}
