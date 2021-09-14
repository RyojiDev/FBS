
using System.Threading.Tasks;
using FBS.Domain.Command;
using Microsoft.AspNetCore.Mvc;

namespace FBS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseItemController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetAllPurchaseItem()
        {
            return null;
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> AddPurchaseItem([FromBody] AddPurchaseItemCommand addCommand)
        {
            return null;
        }
    }
}