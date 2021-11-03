using FBS.Domain.Command;
using FBS.Domain.Interfaces;
using FBS.Domain.Querys;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FBS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseItemController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PurchaseItemController(IPurchaseItemService purchaseItemService, IMediator mediator)
        {
            this._mediator = mediator;

        }

        [Route("GetAllPurchaseItem")]
        [HttpGet]
        public async Task<IActionResult> GetAllPurchaseItem()
        {
            var purchaseItemsList = await _mediator.Send(new GetAllPurchaseItemsQuery());
            return await Task.FromResult(Ok(purchaseItemsList));
        }

        [Route("AddPurchaseItem")]
        [HttpPost]
        public async Task<IActionResult> AddPurchaseItem([FromBody] AddPurchaseItemCommand addCommand)
        {
            if(!ModelState.IsValid)
                return null;
            
            var item = await _mediator.Send(addCommand);

            return await Task.FromResult(Ok(item));
        }
    }
}