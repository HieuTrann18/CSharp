using ProductManagementAdvance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.Interfaces
{
    interface ICategoryServices
    {
        List<Category> GetAllCategory();
    }
}
