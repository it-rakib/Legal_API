using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CardTransaction
    {
        public long Id { get; set; }
        public int? PaymentId { get; set; }
        public int? MemoNo { get; set; }
        public int? DueMemoNo { get; set; }
        public int? ModuleId { get; set; }
        public int? CardId { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? Charge { get; set; }
        public string CardNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? EnterdBy { get; set; }
    }
}
