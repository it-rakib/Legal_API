using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AccReceiptPayment
    {
        public int Id { get; set; }
        public DateTime? ReDate { get; set; }
        public int? ReHeadId { get; set; }
        public int? ReVoucherNo { get; set; }
        public decimal? ReCash { get; set; }
        public decimal? ReBank { get; set; }
        public decimal? PayCash { get; set; }
        public decimal? PayBank { get; set; }
        public string ReBankRemark { get; set; }
    }
}
