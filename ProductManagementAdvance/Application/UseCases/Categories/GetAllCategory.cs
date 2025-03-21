using ProductManagementAdvance.Application.Interfaces;
using ProductManagementAdvance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.UseCases.Categories
{
    class GetAllCategory
    {
        private ICategoryServices _categoryServices;
        public GetAllCategory(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public List<Category> Execute()
        {
            return _categoryServices.GetAllCategory();
        }
    }
}
