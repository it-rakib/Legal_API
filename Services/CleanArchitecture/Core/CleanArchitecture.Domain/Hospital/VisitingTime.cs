using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class VisitingTime
    {
        public int Id { get; set; }
        public TimeSpan? VisitingTime1 { get; set; }
        public bool? Allocated { get; set; }
        public int? DoctorId { get; set; }
    }
}
