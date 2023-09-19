using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class VoucherDetail
    {
        public long Id { get; set; }
        public string VoucherNo { get; set; }
        public int HeadId { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentType { get; set; }
        public int? ParentHeadId { get; set; }
        public int? SubLedgerHeadId { get; set; }
    }
}
