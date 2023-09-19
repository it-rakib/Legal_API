using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientObservation
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public DateTime ObservationDate { get; set; }
        public string Detail { get; set; }
        public string Remarks { get; set; }
        public string Advise { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
