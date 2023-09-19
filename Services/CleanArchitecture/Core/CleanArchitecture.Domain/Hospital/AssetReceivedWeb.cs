using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AssetReceivedWeb
    {
        public long Id { get; set; }
        public int Supplier { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool IsPosted { get; set; }
        public decimal Total { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string ChallanNo { get; set; }
        public DateTime? ChallanDate { get; set; }
        public string PoNo { get; set; }
        public DateTime PoDate { get; set; }
    }
}
