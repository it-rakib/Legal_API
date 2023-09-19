using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreIssueSub
    {
        public long Id { get; set; }
        public long IssueNo { get; set; }
        public int? ProductId { get; set; }
        public int? Slno { get; set; }
        public decimal? BuyRate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Total { get; set; }
        public decimal? IssueRate { get; set; }
        public decimal? Reqestedqty { get; set; }
    }
}
