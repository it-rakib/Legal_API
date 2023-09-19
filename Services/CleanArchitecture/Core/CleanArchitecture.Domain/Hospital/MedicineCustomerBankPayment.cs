using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineCustomerBankPayment
    {
        public int Id { get; set; }
        public long CustomerPaymentId { get; set; }
        public string Bank { get; set; }
        public string ChequeNo { get; set; }
    }
}
