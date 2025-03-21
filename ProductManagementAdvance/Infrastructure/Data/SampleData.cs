using ProductManagementAdvance.Domain.Entities;



namespace ProductManagementAdvance.Infrastructure.Data
{
    class SampleData
    {
        public static List<Product> ProductData = new List<Product>
        {
            new Product(101, "Laptop", 1200, 10),
            new Product(102, "T-Shirt", 20, 100),
            new Product(103, "Refrigerator", 500, 5)
        };

        public static List<Category> CategoryData = new List<Category>
        {
            new Category(1, "Electronics"),
            new Category(2, "Clothing"),
            new Category(3, "Home Appliances")

        };

        public static void SeedData()
        {
            CreateProduct(ProductData[0], CategoryData[0]);
            CreateProduct(ProductData[1], CategoryData[1]);
        }

        public static void CreateProduct(Product product, Category category)
        {
            if (!product.Categories.Contains(category)){
                product.Categories.Add(category);
            }

            if (!category.Products.Contains(product))
            {
                category.Products.Add(product);
            }
        }
    }
}
