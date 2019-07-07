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
        public long Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public ToDoItem(string description)
        {
            Description = description;
        }
    }
}