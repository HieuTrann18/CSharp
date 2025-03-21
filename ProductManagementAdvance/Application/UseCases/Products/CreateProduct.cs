using ProductManagementAdvance.Application.Interfaces;
using ProductManagementAdvance.Application.Validation;
using ProductManagementAdvance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.UseCases.Products
{
    class CreateProduct
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryServices _categoryServices;

        public CreateProduct(IProductServices productServices, ICategoryServices categoryServices)
        {
            _productServices = productServices;
            _categoryServices = categoryServices;
        }

        public void Execute()
        {
            Console.WriteLine("=== Add New Product ===");
            int id = _productServices.GenerateNewProductId();
            int idCount = id++;
            string name = ProductValidator.GetValidString("Enter product name: ", "Product name cannot be empty.");
            double price = ProductValidator.GetValidDouble("Enter product price: ", "Price must be greater than zero.");
            int quantity = ProductValidator.GetValidInt("Enter product quantity: ", "Quantity must be greater than zero.");
            var categories = ListCategory();
            if (categories.Count == 0)
            {
                Console.WriteLine("No categories available. Please add categories first.");
                return;
            }

            int categoryIndex = ProductValidator.GetValidInt("Enter category number: ", "Invalid category number.") - 1;
            if (categoryIndex < 0 || categoryIndex >= categories.Count)
            {
                Console.WriteLine("Invalid category selection.");
                return;
            }
            var selectedCategory = categories[categoryIndex];
            var categoryList = new List<Category> { selectedCategory };
            Product newProduct = new Product(idCount, name, price, quantity, categoryList);
            _productServices.CreateProduct(newProduct);
            Console.WriteLine("Product added successfully!");

        }

        public List<Category> ListCategory()
        {
            var categories = _categoryServices.GetAllCategory();

            Console.WriteLine("Select a category:");
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i].CategoryName}");
            }
            return categories;
        }
    }
}
