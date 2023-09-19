using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenDebtorLedger
    {
        public long Id { get; set; }
        public int DebtorId { get; set; }
        public long BillNo { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransDate { get; set; }
    }
}
