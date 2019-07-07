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
        private ItemContext _context;

        public ItemRepository()
        {
            _context = new ItemContext();
        }

        public List<ToDoItem> GetAll()
        {
            List<ToDoItem> items = _context.ToDos.ToList();
            return items;
        }

        public List<ToDoItem> GetPending()
        {
            List<ToDoItem> items = _context.ToDos.Where(x => !x.Status).ToList();
            return items;
        }

        public List<ToDoItem> GetDone()
        {
            List<ToDoItem> items = _context.ToDos.Where(x => x.Status).ToList();
            return items;
        }

        public ToDoItem Get(long id)
        {
            ToDoItem item = _context.ToDos.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public void Delete(long id)
        {
            ToDoItem item = Get(id);
            _context.Remove(item);
            _context.SaveChanges();
        }

        public void Add(ToDoItem item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool IsValidId(int id)
        {
            bool isValid = _context.ToDos.Any(x => x.Id == id);
            return isValid;
        }
    }
}
