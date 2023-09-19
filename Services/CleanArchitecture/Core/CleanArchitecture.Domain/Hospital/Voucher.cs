using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Voucher
    {
        public long Id { get; set; }
        public string VoucherNo { get; set; }
        public string Type { get; set; }
        public string Mode { get; set; }
        public DateTime TransDate { get; set; }
        public string Description { get; set; }
        public int? BankId { get; set; }
        public string EnteredBy { get; set; }
        public bool IsPosted { get; set; }
        public int? CoyId { get; set; }
        public string TranType { get; set; }
    }
}
