using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DuePayment
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
        public int? ModuleId { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? BkashAmount { get; set; }
        public decimal? ChequeAmount { get; set; }
        public string CardName { get; set; }
        public string ChequeNo { get; set; }
    }
}
