using QuanLySanPham.Controller;
using QuanLySanPham.Entities;
using QuanLySanPham.Services;

namespace QuanLySanPham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(1 ,"Tao", 1200, 5),
            };

            ProductService productService = new ProductService(products);
            ProductController productController = new ProductController(productService);

         
           
            Console.WriteLine("Hello World");


           
            int choice;

            do
            {
                Console.WriteLine("|==========Menu==========|");
                Console.WriteLine("|1.Them san pham moi.....|");
                Console.WriteLine("|2.Danh sach san pham....|");
                Console.WriteLine("|3.Tim kiem san pham.....|");
                Console.WriteLine("|4.Sua san pham..........|");
                Console.WriteLine("|5.Sap xep san pham......|");
                Console.WriteLine("|6.Thoat chuong trinh....|");
                Console.WriteLine("Lua chon cua ban: ");
                string choiceParse = Console.ReadLine();
                if(!int.TryParse(choiceParse, out choice))
                {
                    Console.WriteLine("Lua chon khong hop le vui long chon tu (1-6)");
                }
                switch (choice)
                {
                    case 1:
                        productController.AddNewProduct();
                        break;
                    case 2:
                        productController.DisplayAllProduct();
                        break;
                    case 3:
                        productController.SearchProductById();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Thoat chuong trinh.....");
                        break;
                }
            } while (choice != 6);

         


        }
    }
}
