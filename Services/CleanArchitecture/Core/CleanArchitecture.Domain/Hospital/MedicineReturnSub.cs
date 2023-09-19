using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineReturnSub
    {
        public long Id { get; set; }
        public long MedicineReturnId { get; set; }
        public int ServiceId { get; set; }
        public int Slno { get; set; }
        public decimal Quantity { get; set; }
        public decimal BuyRate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string BatchNo { get; set; }
    }
}
