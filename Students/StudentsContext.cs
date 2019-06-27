using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Students
{
    class StudentsContext : DbContext
    {
        private DbSet<Students> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo exeDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo projectBase = exeDirectory.Parent.Parent.Parent;
            string dbFile = Path.Combine(projectBase.FullName, "Students.db");

            optionsBuilder.UseSqlite("Data Source=" + dbFile);
        }
    }
}
