using ProductManagementAdvance.Application.Interfaces;
using ProductManagementAdvance.Application.UseCases.Products;
using ProductManagementAdvance.Application.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Presentation.Controller
{
    class ProductController
    {
        private IProductServices productServices;

        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }

        public void SearchProductByName()
        {
           
        }

        public void CreateProduct()
        {
           
        }
    }
}
