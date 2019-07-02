using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp_1
{
    class ToDoItem
    {
        public int Id { get; private set; } // ID Property 
        public string Description { get; set; } // Description Property
        public string Status { get; set; } // Flag Property
        public ToDoItem(string Description, string Status)
        {
            this.Description = Description;
            this.Status = Status;
        }
    }
}
