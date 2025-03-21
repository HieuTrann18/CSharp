using ProductManagementAdvance.Application.Interfaces;
using ProductManagementAdvance.Application.Services;
using ProductManagementAdvance.Application.UseCases.Products;
using ProductManagementAdvance.Domain.Entities;
using ProductManagementAdvance.Presentation.Controller;
using ProductManagementAdvance.Presentation.Menus;
using System.Runtime.CompilerServices;



namespace ProductManagementAdvance.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductServices productService = new ProductServices();


            ProductController productController = new ProductController(productService);

            MenuServices menuServices = new MenuServices(productController);

            menuServices.ShowMenu();
        }
    }
}
