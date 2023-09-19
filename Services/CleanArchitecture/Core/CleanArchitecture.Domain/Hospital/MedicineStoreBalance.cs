using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineStoreBalance
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int MedicineStoreId { get; set; }
        public decimal Balance { get; set; }
        public DateTime? ExpireDate { get; set; }
        public long? MedicineReceivingChallanSubId { get; set; }
        public string BatchNo { get; set; }
    }
}
