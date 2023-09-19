using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoReturn
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string RegNo { get; set; }
        public string PatientType { get; set; }
        public decimal? Total { get; set; }
        public decimal? Discount { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public bool IsPackage { get; set; }
        public bool? IsCredit { get; set; }
        public int? BufferStore { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? BkashAmount { get; set; }
        public decimal? ChequeAmount { get; set; }
        public string CardName { get; set; }
        public string ChequeNo { get; set; }
        public string Note { get; set; }
        public int? CustomerId { get; set; }
        public decimal? DuePaid { get; set; }
        public DateTime? Ddate { get; set; }
        public int? PaidBy { get; set; }
        public decimal? Paid { get; set; }
        public decimal? DueDiscount { get; set; }
        public decimal? CustomerPointEarn { get; set; }
        public decimal? CustomerPointRedeem { get; set; }
        public decimal? CustomerPointAmtRedeem { get; set; }
        public long? IndentId { get; set; }
        public string PatientId { get; set; }
    }
}
