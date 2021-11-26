using AutoMapper;
using FBS.Domain.Command;
using FBS.Domain.Dto.Category;
using FBS.Domain.Interfaces.Services;
using FBS.Domain.Models;
using FBS.Domain.Querys;
using FBS.Shared.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FBS.Domain.Handlers
{
    public class AddCategoryCommandHandler :
        IRequestHandler<AddCategoryCommand, GenericResponse<CategoryDto>>,
        IRequestHandler<GetAllCategoriesQuery,List<CategoryDto>>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public AddCategoryCommandHandler(ICategoryService categoryService, IMapper mapper)
        {
            this._categoryService = categoryService;
            this._mapper = mapper;
        }

        public async Task<GenericResponse<CategoryDto>> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        { 
            await _categoryService.SaveCategory(request.CategoryDto);

            return new GenericResponse<CategoryDto>("Saved Category with success", true, request.CategoryDto); 
        }

        public async Task<List<CategoryDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categoriesDto = _mapper.Map<CategoryDto[]>(await _categoryService.GetAllCategories());

            return await Task.FromResult(categoriesDto.ToList());
        }
    }
}
