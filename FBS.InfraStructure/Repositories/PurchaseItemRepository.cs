using FBS.Domain.Interfaces;
using FBS.Domain.Models;
using FBS.InfraStructure.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBS.InfraStructure.Repositories
{
    public class PurchaseItemRepository : IPurchaseItemRepository
    {
        private readonly DataBaseItemContext _dbContext;

        public PurchaseItemRepository(DataBaseItemContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public List<PurchaseItem> GetAllPurchaseItem()
        {
           var purchaseItems = _dbContext.PurchaseItems.Include( p=> p.Category).ToList();
            return purchaseItems;
        }

        public async Task SavePurchaseItem(PurchaseItem item)
        {
            await _dbContext.PurchaseItems.AddAsync(item).ConfigureAwait(true);
            _dbContext.SaveChanges();
        }

    }
}
