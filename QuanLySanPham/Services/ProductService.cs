using QuanLySanPham.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Services
{
    class ProductService
    {
        private List<Product> productList;

        public ProductService(List<Product> productList)
        {
            this.productList = productList;
        }

        public void AddNewProduct(Product product)
        {
            if (product == null)
            {
                return;
            }
            else
            {
                productList.Add(product);
            }
        }

        public List<Product> GetAllProduct()
        {
            return productList;
        }

        public Product SearchProductById(int keyword)
        {
            return productList.Where(x => x.Id.Equals(keyword)).FirstOrDefault();
        }

        public int GetLengthOfArrays()
        {
            return productList.Count > 0 ? productList.Max(p => p.Id) + 1 : 1;
        }
    }
}
