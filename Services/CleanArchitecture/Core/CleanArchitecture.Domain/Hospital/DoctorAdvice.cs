using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DoctorAdvice
    {
        public int Id { get; set; }
        public string AdvShortCode { get; set; }
        public string Details { get; set; }
        public string AppFor { get; set; }
    }
}
