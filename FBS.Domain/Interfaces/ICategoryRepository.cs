using FBS.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBS.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task SaveCategory(Category category);
        Task<List<Category>> GetAllCategory();
    }
}
