using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoApp_1
{
    class ItemContext : DbContext
    {
        public DbSet<ToDoItem> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExeDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExeDirectory.Parent.Parent.Parent;

            String DbFile = Path.Combine(ProjectBase.FullName, "todo.db");

            optionsBuilder.UseSqlite("Data Source=" + DbFile);
        }
    }
}
