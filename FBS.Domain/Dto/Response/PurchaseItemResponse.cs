using FBS.Shared.Response;

namespace FBS.Domain.Dto.Response
{
    public class PurchaseItemResponse : GenericResponse<PurchaseItemDto>
    {
        public PurchaseItemResponse() 
            : base ("", false, new PurchaseItemDto() )
        {

        }

        public PurchaseItemResponse(string message, bool success, PurchaseItemDto data)
            : base (message, success, data ?? new PurchaseItemDto())
        {
            
        }
    }
}
