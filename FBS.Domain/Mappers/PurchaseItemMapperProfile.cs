using AutoMapper;
using FBS.Domain.Dto.Response;
using FBS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.Domain.Mappers
{
    public class PurchaseItemMapperProfile : Profile
    {
        public PurchaseItemMapperProfile()
        {
            CreateMap<PurchaseItem, PurchaseItemDto>().ReverseMap();
        }
    }
}
