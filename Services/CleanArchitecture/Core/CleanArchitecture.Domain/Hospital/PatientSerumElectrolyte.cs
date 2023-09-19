using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientSerumElectrolyte
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string Sodium { get; set; }
        public string Potassium { get; set; }
        public string Chloride { get; set; }
        public string TotalCarbondioxide { get; set; }
    }
}
