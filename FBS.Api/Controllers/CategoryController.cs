using FBS.Domain.Command;
using FBS.Domain.Dto.Category;
using FBS.Domain.Querys;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _mediator.Send(new GetAllCategoriesQuery());
           return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> SaveCategory(CategoryDto category)
        {
            if (category == null)
                return BadRequest();

            var response = await _mediator.Send(new AddCategoryCommand(category));

            return Ok(response);
        }
    }
}
