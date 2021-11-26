using FBS.Domain.Dto.Category;
using FBS.Shared.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.Domain.Command
{
    public class AddCategoryCommand : IRequest<GenericResponse<CategoryDto>>
    {
        public AddCategoryCommand(CategoryDto categoryDto)
        {
            this.CategoryDto = categoryDto;
        }

        public CategoryDto CategoryDto { get; set; }
    }
}
