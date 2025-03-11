using LibraryManagement.Controller;
using LibraryManagement.Entities;
using LibraryManagement.Services;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            List<Book> books = new List<Book>()
            {
                new Book(1, "Dragon ball", "Hieu"),
                new Book(2, "One Piece", "Long"),
                new Book(3, "Solo leveling", "Hieu"),
                new Book(4, "Attack on titan", "Long"),
                new Book(5, "Doraemon", "Hieu"),
                new Book(6, "Java programing", "Long")
            };

            BookServices bookServices = new BookServices(books);
            BookController bookController = new BookController(bookServices);




            int chooseParse;
            do
            {

                Console.WriteLine("============Menu============");
                Console.WriteLine("1.Them moi sach........");
                Console.WriteLine("2.Hien thi danh sach........");
                Console.WriteLine("3.Tim kiem sach theo tieu de");
                Console.WriteLine("4.Loc sach theo tac gia.....");
                Console.WriteLine("5.Thoat chuong trinh........");
                Console.WriteLine("============================");
                Console.WriteLine("Lua chon cua ban: ");

                string choose = Console.ReadLine();

                if(!int.TryParse(choose, out chooseParse))
                {
                    Console.WriteLine("Please enter a number from 1 to 5");
                    continue;
                }


                switch (chooseParse)
                {
                    case 1:
                        bookController.AddNewBook();
                        break;
                    case 2:
                        bookController.DisplayAllBook();
                        break;
                    case 3:
                        bookController.Search();
                        break;
                    case 4:
                        bookController.FilterByAuthor();
                        break;
                    case 5:
                        Console.WriteLine("Exiting.......");
                        break;
                    default:
                        break;

                }

            } while (chooseParse != 5);
        }
    }
}
