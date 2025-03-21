using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Domain.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

       public Category(int id, string name)
        {
            this.Id = id;
            this.CategoryName = name;
        }

      
    }
}
