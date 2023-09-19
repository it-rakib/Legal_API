using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? BuyRate { get; set; }
        public decimal? Balance { get; set; }
        public int? ReorderLevel { get; set; }
        public string Unit { get; set; }
        public bool? IsKitchenItem { get; set; }
    }
}
