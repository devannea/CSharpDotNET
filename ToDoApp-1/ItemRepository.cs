using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp_1
{
    class ItemRepository // CRUD
    {
        ItemContext context;
        public ItemRepository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }
        public List<ToDoItem> GetToDoItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems;
            return list.ToList();
        }
        public void AddItem(string description, string status)
        {

        }
        //private List<ToDoItem> _db; // _db for data base :O
        //public ItemRepository()
        //{
        //    _db = new List<ToDoItem>();
        //}
        //public int Create(ToDoItem item)
        //{
        //    return 0;
        //}
        //public ToDoItem Read(int id)
        //{
        //    return new ToDoItem();
        //}
        //public void Update(ToDoItem item)
        //{
        //    //
        //}
        //public void Delete(int id)
        //{
        //    //
        //}
        //public List<ToDoItem> ReadAll()
        //{
        //    return _db;
        //}
    }
}
