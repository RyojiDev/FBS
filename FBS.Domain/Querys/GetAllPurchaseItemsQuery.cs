using FBS.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.Domain.Querys
{
    public class GetAllPurchaseItemsQuery : IRequest<List<PurchaseItem>>
    {
    }
}
