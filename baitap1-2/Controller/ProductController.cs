using baitap1_2.Entities;
using baitap1_2.Services;
using baitap1_2.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1_2.Controller
{
    class ProductController
    {
        private ProductService productService;
        private static int autoIncrementId ;
        

        public ProductController(ProductService productService)
        {
            this.productService = productService;
            autoIncrementId = productService.GetLengthOfIndex();
        }

        public void AddProduct()
        {
            int id = autoIncrementId++;

            string name = ProductValid.ValidateStringInput("Nhập tên sản phẩm");

            float price = ProductValid.ValidateFloatInput("Nhập giá sản phẩm: ");

            Product product = new Product(id, name, price);

            productService.AddProduct(product);

            Console.WriteLine("Thêm sản phẩm thành công");
        }

        public void DisplayProduct()
        {
            List<Product> result = productService.GetAllProduct();
            if(result.Count == 0)
            {
                Console.Write("Không tìm thấy sản phẩm nào");
            }
            else
            {
                foreach (var item in result)
                {
                    item.DisplayInfo();
                }
            }
        }
    }
}
