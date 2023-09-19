using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineRequisition
    {
        public long Id { get; set; }
        public int? CounterFrom { get; set; }
        public int? CounterTo { get; set; }
        public int EnteredBy { get; set; }
        public int? DeliveredBy { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime TransDate { get; set; }
    }
}
