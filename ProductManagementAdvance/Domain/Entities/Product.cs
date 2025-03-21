using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Domain.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public double Price { get; set; }

        public List<Category> Categories { get; set; } = new List<Category>();

        public int Quantity { get; set; }

        public Product(int id, string name, double price, int quantity, List<Category> categories)
        {
            this.Id = id;
            this.ProductName = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Categories = categories;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {ProductName}");
        }

        
    }
}
