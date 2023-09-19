using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PrescriptionInvestigation
    {
        public int Id { get; set; }
        public long? PrescriptionId { get; set; }
        public int? ServiceId { get; set; }
        public int? Quantity { get; set; }
        public int? Slno { get; set; }
    }
}
