using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class SupplierBankPayment
    {
        public int Id { get; set; }
        public long SupplierPaymentId { get; set; }
        public string Bank { get; set; }
        public string ChequeNo { get; set; }
    }
}
