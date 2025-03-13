using baitap1_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1_2.Services
{
    class ProductService
    {
        private List<Product> products;

        public ProductService(List<Product> products)
        {
            this.products = products;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetAllProduct()
        {
            return products;
        }

        public int GetLengthOfIndex()
        {
            return products.Count > 0 ? products.Max(p => p.Id) + 1 : 1;
        }
    }
}
