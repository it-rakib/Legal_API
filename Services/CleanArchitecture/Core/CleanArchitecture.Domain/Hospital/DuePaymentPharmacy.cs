using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DuePaymentPharmacy
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public DateTime TransDate { get; set; }
        public decimal? DueDiscount { get; set; }
        public string DiscountBy { get; set; }
        public decimal? DuePaid { get; set; }
        public decimal? CurrentDue { get; set; }
        public string Remarks { get; set; }
        public int? EnteredBy { get; set; }
        public string PatientType { get; set; }

        public virtual CashMemo Memo { get; set; }
    }
}
