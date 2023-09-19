using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineReturn
    {
        public long Id { get; set; }
        public int SupplierId { get; set; }
        public int StoreId { get; set; }
        public bool IsPosted { get; set; }
        public DateTime TransDate { get; set; }
        public int EnteredBy { get; set; }
    }
}
