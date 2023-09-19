using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoInvestRefComm
    {
        public int CashMemoInvRefId { get; set; }
        public long? CashMemoId { get; set; }
        public int? QdoctorId { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? Payment { get; set; }
        public string PaymentMode { get; set; }
        public int? EnteredBy { get; set; }
    }
}
