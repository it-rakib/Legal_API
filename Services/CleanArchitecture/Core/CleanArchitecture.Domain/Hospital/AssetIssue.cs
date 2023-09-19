using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AssetIssue
    {
        public long Id { get; set; }
        public int? IssueDepartment { get; set; }
        public string IssueNo { get; set; }
        public int? AssetId { get; set; }
        public int? Quantity { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Total { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public bool? IsPosted { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string SerialNo { get; set; }
        public string Origin { get; set; }
        public string TagNo { get; set; }
        public string FloorNo { get; set; }
        public string Room { get; set; }
    }
}
