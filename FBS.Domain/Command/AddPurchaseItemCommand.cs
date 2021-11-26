using FBS.Domain.Dto.Response;
using FBS.Shared.Response;
using MediatR;

namespace FBS.Domain.Command
{
    public class AddPurchaseItemCommand : IRequest<GenericResponse<PurchaseItemDto>>
    {
        public AddPurchaseItemCommand(PurchaseItemDto purchaseItemDto)
        {
            this.PurchaseItemDto = purchaseItemDto;
        }

        public PurchaseItemDto PurchaseItemDto { get; set; }
    }
}