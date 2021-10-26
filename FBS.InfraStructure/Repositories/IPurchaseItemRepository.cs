using FBS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.InfraStructure.Repositories
{
    public interface IPurchaseItemRepository
    {
        void SavePurchaseItem(PurchaseItem item);
    }
}
