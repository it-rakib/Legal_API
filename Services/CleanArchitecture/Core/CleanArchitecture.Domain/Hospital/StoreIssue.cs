using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreIssue
    {
        public long Id { get; set; }
        public int IssueDepartment { get; set; }
        public string IndentNo { get; set; }
        public decimal? Total { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
