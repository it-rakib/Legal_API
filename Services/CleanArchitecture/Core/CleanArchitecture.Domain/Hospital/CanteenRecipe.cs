using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenRecipe
    {
        public long Id { get; set; }
        public int? ProductId { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public int? UserId { get; set; }
    }
}
