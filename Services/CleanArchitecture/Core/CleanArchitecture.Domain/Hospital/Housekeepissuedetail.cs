using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Housekeepissuedetail
    {
        public int Id { get; set; }
        public int? IssueId { get; set; }
        public int? ProductId { get; set; }
        public decimal? BuyRate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Total { get; set; }
    }
}
