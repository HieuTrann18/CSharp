using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities
{
    class Book
    {   
        private int id { get; set; }
        private string title { get; set; }

        private string author { get; set; }


        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetId()
        {
            return id;
        }
        public Book(int id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {id}, Title: {title}, Author: {author}");
        }


    }
}
