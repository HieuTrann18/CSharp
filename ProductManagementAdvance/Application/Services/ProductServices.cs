using ProductManagementAdvance.Application.Interfaces;
using ProductManagementAdvance.Domain.Entities;
using ProductManagementAdvance.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.Services
{
    class ProductServices : IProductServices
    {
        public List<Product> FilterProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct() => SampleData.ProductData;
        
           
        

        public Product GetProductById(int id) =>
            SampleData.ProductData.Where(p => p.Id == id).FirstOrDefault();
        

        public List<Product> SearchProducts(string keyword) =>
            SampleData.ProductData.Where(p => p.ProductName.ToLower().Contains(keyword.ToLower())).ToList();

        public  int GenerateNewProductId()
        {
            return SampleData.ProductData.Count > 0 ? SampleData.ProductData.Max(p => p.Id) + 1 : 1;
        }

        public void CreateProduct(Product product)
        {
           if(product != null)
            {
                SampleData.ProductData.Add(product);
            }
        }
    }
}
