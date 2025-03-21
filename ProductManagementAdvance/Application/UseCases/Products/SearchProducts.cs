using ProductManagementAdvance.Application.Interfaces;
using ProductManagementAdvance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.UseCases.Products
{
    class SearchProducts
    {
        private readonly IProductServices _productService;

        public SearchProducts(IProductServices productService)
        {
            _productService = productService;
        }

        public List<Product> Excute(string keyword)
        {
            return _productService.SearchProducts(keyword);
        }
    }
}
