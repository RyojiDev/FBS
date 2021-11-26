using System;
using FBS.Domain.Models;

namespace FBS.Domain.Dto.Response
{
    public class PurchaseItemDto
    {
        public string Name { get;  set; }
        public bool MissingItem { get;  set; }
        public DateTime AddDate { get; set; }
        public int CategoryId { get; set; }
    }
}