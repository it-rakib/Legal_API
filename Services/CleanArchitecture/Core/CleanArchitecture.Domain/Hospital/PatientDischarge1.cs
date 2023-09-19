using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientDischarge1
    {
        public int Id { get; set; }
        public long PatientId { get; set; }
        public string Title { get; set; }
        public string Result { get; set; }
        public int? LabModuleId { get; set; }
        public string ReportHeader { get; set; }
        public string Advice { get; set; }
    }
}
