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

        }
        
    }
    class Controller
    {
        // the brains the manages all the rules and coordinates the user interactions and the "database" interactions
    }
    class ItemRepository // CRUD
    {
        private List<ToDoItem> _db; // _db for data base :O
        public ItemRepository()
        {
            _db = new List<ToDoItem>();
        }
        public int Create(ToDoItem item)
        {
            return 0;
        }
        public ToDoItem Read(int id)
        {
            return new ToDoItem();
        }
        public void Update(ToDoItem item)
        {
            //
        }
        public void Delete(int id)
        {
            //
        }
        public List<ToDoItem> ReadAll()
        {
            return _db;
        }
    }
    class ConsoleUtils
    {

    }
    class ToDoItem
    {
        public string Description { get; set; } // Description Property
        public int Id { get; set; } // ID Property 
        public bool Done { get; set; } // Flag Property
    }
}
