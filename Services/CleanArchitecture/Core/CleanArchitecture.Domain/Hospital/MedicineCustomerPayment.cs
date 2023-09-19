using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineCustomerPayment
    {
        public long Id { get; set; }
        public int MedicineCustomerId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMode { get; set; }
        public string CollectedBy { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
