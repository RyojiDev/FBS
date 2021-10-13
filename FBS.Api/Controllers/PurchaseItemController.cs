
using System.Collections.Generic;
using System.Threading.Tasks;
using FBS.Domain.Command;
using FBS.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FBS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseItemController : ControllerBase
    {
        [Route("GetAllPurchaseItem")]
        [HttpGet]
        public async Task<IActionResult> GetAllPurchaseItem()
        {
            return await Task.FromResult(Ok(new List<PurchaseItem>()
            {
               new PurchaseItem("Ouro branco", true, new Category("Chocolate"))
            })).ConfigureAwait(false);
        }

        [Route("AddPurchaseItem")]
        [HttpPost]
        public async Task<IActionResult> AddPurchaseItem([FromBody] AddPurchaseItemCommand addCommand)
        {
            if(!ModelState.IsValid)
                return null;
            return await Task.FromResult(Ok(addCommand));
        }
    }
}