using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AssetIssueSubWeb
    {
        public long Id { get; set; }
        public decimal AssetId { get; set; }
        public decimal Total { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
        public string IssueNo { get; set; }
    }
}
