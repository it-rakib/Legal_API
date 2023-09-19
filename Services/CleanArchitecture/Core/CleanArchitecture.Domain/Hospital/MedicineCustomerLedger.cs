using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineCustomerLedger
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public long? SalesId { get; set; }
        public long? CustomerPaymentId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransDate { get; set; }
    }
}
