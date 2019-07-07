using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp_1
{
    class Controller
    {
        private ItemRepository _repository;

        public Controller()
        {
            _repository = new ItemRepository();
        }

        public void Start()
        {
            var shouldContinue = true;

            do
            {
                // display menu
                ConsoleUtils.DisplayMenu();

                // get command
                int command = ConsoleUtils.GetCommand();

                // invalid command
                if (command == 0)
                {
                    continue;
                }

                // exit application
                if (command == 7)
                {
                    shouldContinue = false;
                    continue;
                }

                // execute command
                ExecuteCommand(command);

            }
            while (shouldContinue);
        }

        private void ExecuteCommand(int command)
        {
            switch (command)
            {
                case 1:
                    ListPendingItems();
                    break;
                case 2:
                    ListDoneItems();
                    break;
                case 3:
                    ListAllItems();
                    break;
                case 4:
                    MarkItemDone();
                    break;
                case 5:
                    AddItem();
                    break;
                case 6:
                    DeleteItem();
                    break;
            }
        }

        private void ListPendingItems()
        {
            List<ToDoItem> items = _repository.GetPending();

            ConsoleUtils.DisplayHeader("Pending Items");
            foreach (ToDoItem item in items)
            {
                ConsoleUtils.DisplayItem(item);
            }
        }

        private void ListDoneItems()
        {
            List<ToDoItem> items = _repository.GetDone();

            ConsoleUtils.DisplayHeader("Done Items");
            foreach (ToDoItem item in items)
            {
                ConsoleUtils.DisplayItem(item);
            }
        }

        private void ListAllItems()
        {
            List<ToDoItem> items = _repository.GetAll();

            ConsoleUtils.DisplayHeader("All Items");
            foreach (ToDoItem item in items)
            {
                ConsoleUtils.DisplayItem(item);
            }
        }

        private void MarkItemDone()
        {
            int id = ConsoleUtils.RequestId("Enter ID of item to mark done: ");
            if (id != 0)
            {
                bool isValid = _repository.IsValidId(id);
                if (isValid)
                {
                    ToDoItem item = _repository.Get(id);
                    item.Status = true;
                    _repository.Save();

                    ConsoleUtils.WriteMessage("Item updated!");
                }
                else
                {
                    ConsoleUtils.WriteMessage("Invalid ID; please try again.");
                }
            }
        }

        private void AddItem()
        {
            Console.WriteLine("Enter new item: ");
            string description = Console.ReadLine();

            ToDoItem newItem = new ToDoItem(description);
            _repository.Add(newItem);

            ConsoleUtils.WriteMessage("Item added!");
        }

        private void DeleteItem()
        {
            int id = ConsoleUtils.RequestId("Enter ID of item to delete: ");
            if (id != 0)
            {
                bool isValid = _repository.IsValidId(id);
                if (isValid)
                {
                    _repository.Delete(id);

                    ConsoleUtils.WriteMessage("Item deleted!");
                }
                else
                {
                    ConsoleUtils.WriteMessage("Invalid ID; please try again.");
                }
            }
        }
    }
}
