using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreReturnSub
    {
        public long Id { get; set; }
        public long ReturnId { get; set; }
        public int ProductId { get; set; }
        public int? Slno { get; set; }
        public decimal? Total { get; set; }
        public decimal? BuyRate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? SaleRate { get; set; }
    }
}
