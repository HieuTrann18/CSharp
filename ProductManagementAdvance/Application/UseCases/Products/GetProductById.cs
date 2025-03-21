using ProductManagementAdvance.Application.Interfaces;
using ProductManagementAdvance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.UseCases.Products
{
    class GetProductById
    {
        private readonly IProductServices _productServices;

        public GetProductById(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public Product Execute(int keyword)
        {
            Product result = _productServices.GetProductById(keyword);
            if(result == null)
            {
                Console.WriteLine($"Not found product: {keyword}");
            }
            return result;
        }
    }
}
