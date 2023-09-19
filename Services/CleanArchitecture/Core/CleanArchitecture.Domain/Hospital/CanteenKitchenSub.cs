using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenKitchenSub
    {
        public long Id { get; set; }
        public long? KitchenId { get; set; }
        public int? MatiralId { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public int? UserId { get; set; }
    }
}
