using AutoMapper;
using FBS.Domain.Command;
using FBS.Domain.Dto.Response;
using FBS.Domain.Interfaces;
using FBS.Domain.Models;
using FBS.Domain.Querys;
using FBS.Shared.Response;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FBS.Domain.Handlers
{
    public class AddPurchaseItemCommandHandler : 
        IRequestHandler<AddPurchaseItemCommand, GenericResponse<PurchaseItemDto>>,
        IRequestHandler<GetAllPurchaseItemsQuery, List<PurchaseItem>>
    {
        private readonly IPurchaseItemService _purchaseItemService;
        private readonly IMapper _mapper;

        public AddPurchaseItemCommandHandler(IPurchaseItemService purchaseItemService, IMapper mapper)
        {
            this._purchaseItemService = purchaseItemService;
            this._mapper = mapper;
        }

        public Task<GenericResponse<PurchaseItemDto>> Handle(AddPurchaseItemCommand request, CancellationToken cancellationToken)
        {
            var requestDeliveryItem = this._mapper.Map<PurchaseItem>(request.PurchaseItemDto);

            this._purchaseItemService.SavePurchaseItem(requestDeliveryItem);

            var requestDto = _mapper.Map<PurchaseItemDto>(requestDeliveryItem);

            return Task.FromResult(new GenericResponse<PurchaseItemDto>("Registered Successfully", true, requestDto));
        }

        public  Task<List<PurchaseItem>> Handle(GetAllPurchaseItemsQuery request, CancellationToken cancellationToken)
        {
            var requestAllPurchaseItem = this._purchaseItemService.GetAllPurchaseItem();
            return Task.FromResult(requestAllPurchaseItem);
        }
    }
}
