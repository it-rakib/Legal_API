using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PrescriptionMedicine
    {
        public int Id { get; set; }
        public long? PrescriptionId { get; set; }
        public int? ServiceId { get; set; }
        public decimal? Interval { get; set; }
        public int? Dose { get; set; }
        public int? Days { get; set; }
        public string DaysFor { get; set; }
        public int? Quantity { get; set; }
        public int? Slno { get; set; }
        public string Remarks { get; set; }
        public string DozeTime { get; set; }
        public string RouteId { get; set; }
    }
}
