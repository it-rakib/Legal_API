using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class SupplierLedger
    {
        public long Id { get; set; }
        public int SupplierId { get; set; }
        public long? ChallanNo { get; set; }
        public long? SupplierPaymentId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransDate { get; set; }
        public string Remarks { get; set; }
    }
}
