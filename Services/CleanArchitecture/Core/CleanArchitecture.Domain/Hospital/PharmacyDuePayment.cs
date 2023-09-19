using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PharmacyDuePayment
    {
        public long Id { get; set; }
        public string Contact { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMode { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string Remarks { get; set; }
        public string MemoId { get; set; }
    }
}
