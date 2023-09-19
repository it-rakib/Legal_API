using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AssetIssueWeb
    {
        public long Id { get; set; }
        public int IssueDepartment { get; set; }
        public string IssueNo { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsPosted { get; set; }
        public string FloorNo { get; set; }
        public string Room { get; set; }
        public decimal SerialNo { get; set; }
        public decimal TagNo { get; set; }
    }
}
