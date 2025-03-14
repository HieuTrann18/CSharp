using QuanLySanPham.Entities;
using QuanLySanPham.Services;
using QuanLySanPham.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Controller
{
    class ProductController
    {
        private ProductService productService;
        private int AutoIncrementId = 1;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
            AutoIncrementId = productService.GetLengthOfArrays();
        }

        public void AddNewProduct()
        {
            int id = AutoIncrementId++;
            string ProductName = ProductValid.StringInputValid("Nhap ten san pham: ", "Ten san pham khong hop le vui long nhap lai!");
            float ProductPrice = ProductValid.FloatInputValid("Nhap gia san pham: ", "Gia san pham khong hop le vui long nhap lai!");
            int Quantity = ProductValid.IntInputValid("So luong: ", "So luong khong hop le vui long nhap lai!");

            Product productExisting = GetProductList().Find(p => p.Name.Equals(ProductName, StringComparison.OrdinalIgnoreCase));
            if (productExisting != null)
            {
                productExisting.Quantity += Quantity;
                Console.WriteLine("Them san pham thanh cong");
            }
            else
            {
                Product product = new Product(id, ProductName, ProductPrice, Quantity);
                productService.AddNewProduct(product);
                Console.WriteLine("Them san pham thanh cong");
            }
        }

        public void DisplayAllProduct()
        {
            List<Product> result = productService.GetAllProduct();
            if(result.Count == 0)
            {
                Console.WriteLine("Khong tim thay san pham nao");
            }
            else
            {
                foreach (var item in result) {
                    item.DisplayInfo();                
                }
            }
        }

        public void SearchProductById()
        {
            int keyword = ProductValid.IntInputValid("Nhap id de tim kiem: ", "Tu khoa khong hop le vui long nhap lai");
            Product result = productService.SearchProductById(keyword);
            if(result == null)
            {
                Console.WriteLine($"Khong tim thay san pham nao ten la {keyword}");
            }
            else
            {
                Console.WriteLine("Ket qua tim kiem: ");
                result.DisplayInfo();
            }
        }
    

        public List<Product> GetProductList()
        {
            return productService.GetAllProduct();
        }
    }
}
