using FBS.Domain.Interfaces;
using FBS.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FBS.Services
{
    public class PurchaseItemService : IPurchaseItemService
    {
        private readonly IPurchaseItemRepository _purchaseItemRepository;
        public PurchaseItemService(IPurchaseItemRepository purchaseItemRepository)
        {
            this._purchaseItemRepository = purchaseItemRepository;
        }

        public List<PurchaseItem> GetAllPurchaseItem()
        {
           return  _purchaseItemRepository.GetAllPurchaseItem();
        }

        public async Task SavePurchaseItem(PurchaseItem purchaseItem)
        {
             await this._purchaseItemRepository.SavePurchaseItem(purchaseItem).ConfigureAwait(true);
        }
    }
}
