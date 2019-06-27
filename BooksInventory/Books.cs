using System;
using System.Collections.Generic;
using System.Text;

namespace BooksInventory
{
    class Books
    {
        public int Id { get; private set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public Books(String title, String author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
}
