using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    class BookServices
    {
        private List<Book> books;
        public BookServices(List<Book> books)
        {
            this.books = books;
        }

        public void AddNewBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> DisplayAllBook()
        {
            return books;
        }
        

        public Book SearchByTitle(String keyword)
        {
            return books.Where(b => b.GetTitle().ToLower().Contains(keyword.ToLower())).FirstOrDefault();
        }

        public List<Book> FilterByAuthor(String keyword)
        {
            return books.Where(b => b.GetAuthor().ToLower().Contains(keyword.ToLower())).ToList();
        }

        public int GetLengthOfIndex()
        {
            return books.Count > 0 ? books.Max(b => b.GetId()) + 1 : 1;
        }

       
    }
}
