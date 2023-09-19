using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PaymentsDetail
    {
        public long Id { get; set; }
        public int ModuleId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long MemoNo { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Cheque { get; set; }
        public decimal? Card { get; set; }
        public decimal? Bkash { get; set; }
        public string CardNo { get; set; }
        public string CardName { get; set; }
        public string ChequeNo { get; set; }
        public decimal? CurrentDue { get; set; }
        public long? EnterdBy { get; set; }
    }
}
