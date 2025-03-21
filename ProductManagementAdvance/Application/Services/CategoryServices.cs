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
    class CategoryServices : ICategoryServices
    {
        public List<Category> GetAllCategory() => SampleData.CategoryData;
        
    }
}
