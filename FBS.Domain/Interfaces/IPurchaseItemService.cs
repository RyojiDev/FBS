using FBS.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBS.Domain.Interfaces
{
    public interface IPurchaseItemService
    {
        Task SavePurchaseItem(PurchaseItem purchaseItem);

        List<PurchaseItem> GetAllPurchaseItem();
    }
}
