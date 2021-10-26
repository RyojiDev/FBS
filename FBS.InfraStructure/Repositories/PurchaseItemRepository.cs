using FBS.Domain.Interfaces;
using FBS.Domain.Models;
using FBS.InfraStructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void SavePurchaseItem(PurchaseItem item)
        {
            _dbContext.PurchaseItems.Add(item);
            _dbContext.SaveChanges();
        }
    }
}
