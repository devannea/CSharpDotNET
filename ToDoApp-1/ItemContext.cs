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
        // code goes here
        public DbSet<ToDoItem> items { get; set; }
    }
}
