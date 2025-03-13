using baitap1_2.Controller;
using baitap1_2.Entities;
using baitap1_2.Services;

namespace baitap1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>()
            {
                new Product(1, "Táo", 1200),
                new Product(2, "Dưa", 1300),

            };

            ProductService productService = new ProductService(products);
            ProductController productController = new ProductController(productService);

            int choice;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhập sản phẩm (ID, Name, Price)");
                Console.WriteLine("2. Hiển thị danh sách sản phẩm");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn chức năng: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Lựa chọn không hợp lệ! Vui lòng nhập lại (1-3): ");
                }

                switch (choice)
                {
                    case 1:

                        productController.AddProduct();
                        break;

                    case 2:
                        productController.DisplayProduct();
                        break;

                    case 3:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                }
            } while (choice != 3);
        }
    }
}
