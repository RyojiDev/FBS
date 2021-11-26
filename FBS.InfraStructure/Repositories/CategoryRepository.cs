using FBS.Domain.Interfaces;
using FBS.Domain.Models;
using FBS.InfraStructure.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.InfraStructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataBaseItemContext _context;

        public CategoryRepository(DataBaseItemContext context)
        {
            this._context = context;
        }

        public async Task<List<Category>> GetAllCategory()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories;
        }


        public async Task SaveCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }
    }
}
