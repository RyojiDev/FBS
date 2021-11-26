using FBS.Domain.Dto.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.Domain.Querys
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryDto>>
    {

    }
}
