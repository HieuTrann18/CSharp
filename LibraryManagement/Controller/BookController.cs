using LibraryManagement.Entities;
using LibraryManagement.Services;
using LibraryManagement.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    class BookController
    {
        private BookServices bookServices;
        private Validations validation = new Validations();
        private static int autoIncrementId = 1;

        public BookController(BookServices bookServices)
        {
            this.bookServices = bookServices;
            autoIncrementId = bookServices.GetLengthOfIndex();
        }

        public void AddNewBook()
        {
            int id = autoIncrementId++;

            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            title = validation.StringValid(title);

            Console.WriteLine("Enter author: ");
            string author = Console.ReadLine();
            author = validation.StringValid(author);

            Book book = new Book(id, title, author);
            bookServices.AddNewBook(book);

            Console.WriteLine("Add new book successfully");
            
        }

        public void DisplayAllBook()
        {
            List<Book> result = bookServices.DisplayAllBook();
            if(result.Count == 0)
            {
                Console.WriteLine("Not found student");
            }
            else
            {
                foreach (var item in result)
                {
                    item.DisplayInfo();
                }
            }
        }

       public Book Search()
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Book result = bookServices.SearchByTitle(title);
            if(result == null)
            {
                Console.WriteLine("Not found book: " + title);
                return null;
            }
            else
            {
                Console.WriteLine("Result search: ");
                result.DisplayInfo();

            }
                return result;
        }

        public List<Book> FilterByAuthor()
        {
            Console.WriteLine("Enter author: ");
            string keyword = Console.ReadLine();
            List<Book> ResultSearch = bookServices.FilterByAuthor(keyword);
            if (ResultSearch.Count == 0)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Search results: ");
                foreach (var book in ResultSearch)
                {
                    book.DisplayInfo();
                }
            }
            return ResultSearch;
        }




    }
}
