using FBS.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBS.Domain.Interfaces
{
    public interface IPurchaseItemRepository
    {
        Task SavePurchaseItem(PurchaseItem item);

        List<PurchaseItem> GetAllPurchaseItem();
    }
}
