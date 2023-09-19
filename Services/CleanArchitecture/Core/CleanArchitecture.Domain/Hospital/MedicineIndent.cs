using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineIndent
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string RegNo { get; set; }
        public decimal? Total { get; set; }
        public decimal? Discount { get; set; }
        public bool? IsPending { get; set; }
        public long? BillNo { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public bool IsPackage { get; set; }
        public int? StoreId { get; set; }
    }
}
