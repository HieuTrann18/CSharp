using ProductManagementAdvance.Presentation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Presentation.Menus
{
    class MenuServices
    {

        private ProductController productController;

        public MenuServices(ProductController productController)
        {
            this.productController = productController;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("|============Menu============|");
                Console.WriteLine("|1.Add new Product...........|");
                Console.WriteLine("|2.Search product by name....|");
                Console.WriteLine("|3.Filter product by price...|");
                Console.WriteLine("|4.Filter product by category|");
                Console.WriteLine("|5.Update product by id......|");
                Console.WriteLine("|6.Remove product by id......|");
                Console.WriteLine("|7.Exit program..............|");
                Console.WriteLine("|============================|");
                Console.WriteLine("Your choose: ");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        break;
                    case "2":
                        productController.SearchProductByName();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
