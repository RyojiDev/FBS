using System;

namespace FBS.Domain.Models
{
    public class PurchaseItem
    {
        public PurchaseItem()
        {

        }

        public PurchaseItem(string name, bool missingItem, Category category)
        {
            Id = Guid.NewGuid();
            Name = name;
            MissingItem = missingItem;
            Category = category;
            AddDate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public bool MissingItem { get; private set; }
        public DateTime AddDate { get; set; }
        public virtual Category Category {get; private set;}
        public int CategoryId { get; set; }
    }
}