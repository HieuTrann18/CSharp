using ProductManagementAdvance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.Interfaces
{
    interface IProductServices
    {
        List<Product> GetAllProduct();
        Product GetProductById(int id);
        List<Product> SearchProducts(string keyword);
        List<Product> FilterProductsByCategory(int categoryId);

        int GenerateNewProductId();

        void CreateProduct(Product product);
    }
}
