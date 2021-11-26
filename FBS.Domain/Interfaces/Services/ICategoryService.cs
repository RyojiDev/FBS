using FBS.Domain.Dto.Category;
using FBS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task SaveCategory(CategoryDto category);
        Task<List<Category>> GetAllCategories();
    }
}
