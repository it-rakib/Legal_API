using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TreatmentSheetMedicine
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string RegNo { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
