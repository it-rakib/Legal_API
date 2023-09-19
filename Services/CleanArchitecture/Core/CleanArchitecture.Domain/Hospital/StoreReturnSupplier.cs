using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreReturnSupplier
    {
        public long Id { get; set; }
        public int SupplierId { get; set; }
        public string ReturnNo { get; set; }
        public int? IssueNo { get; set; }
        public decimal Total { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string Remarks { get; set; }
    }
}
