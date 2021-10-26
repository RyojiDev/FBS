using FBS.Domain.Command;
using FBS.Domain.Interfaces;
using FBS.Domain.Models;
using FBS.Shared.Response;
using MediatR;

namespace FBS.Domain.Handlers
{
    public class AddPurchaseItemCommandHandler : IRequest<string>
    {
        public GenericResponse Handler(AddPurchaseItemCommand addCommand)
        {
            var requestDeliveryItem = new PurchaseItem(addCommand.Name, true, new Category(addCommand.CategoryName));

            return new GenericResponse("Registered Successfully", true, requestDeliveryItem);
        }
    }
}
