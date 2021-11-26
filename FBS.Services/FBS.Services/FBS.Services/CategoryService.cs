using AutoMapper;
using FBS.Domain.Dto.Category;
using FBS.Domain.Interfaces;
using FBS.Domain.Interfaces.Services;
using FBS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBS.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this._categoryRepository = categoryRepository;
            this._mapper = mapper;
            
        }

        private readonly ICategoryRepository _categoryRepository;

        public async Task<List<Category>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllCategory();
            return categories;
        }

        public async Task SaveCategory(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);

            await _categoryRepository.SaveCategory(category);
        }
    }
}
