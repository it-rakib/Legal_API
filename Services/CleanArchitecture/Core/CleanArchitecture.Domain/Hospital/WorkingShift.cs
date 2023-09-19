using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class WorkingShift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public bool? IsNightShift { get; set; }
        public bool? GeneralShift { get; set; }
        public bool? Shifting { get; set; }
        public int? ShiftDept { get; set; }
        public int? TagNo { get; set; }
    }
}
