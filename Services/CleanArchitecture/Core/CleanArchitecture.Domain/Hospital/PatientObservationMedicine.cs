using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientObservationMedicine
    {
        public int Id { get; set; }
        public long? ObservationId { get; set; }
        public int? ServiceId { get; set; }
        public decimal? Interval { get; set; }
        public int? Dose { get; set; }
        public int? Days { get; set; }
        public int? Quantity { get; set; }
        public int? Slno { get; set; }
        public string Remarks { get; set; }
        public string DozeTime { get; set; }
        public int? RouteId { get; set; }
    }
}
