using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DischargeInfoMedicine
    {
        public int Id { get; set; }
        public long? DischargeInfoId { get; set; }
        public int? ServiceId { get; set; }
        public int? RouteId { get; set; }
        public string Dose { get; set; }
        public int? Days { get; set; }
        public int? Quantity { get; set; }
        public int? Slno { get; set; }
        public string Remarks { get; set; }
        public string DozeTime { get; set; }
        public string DaysFor { get; set; }
    }
}
