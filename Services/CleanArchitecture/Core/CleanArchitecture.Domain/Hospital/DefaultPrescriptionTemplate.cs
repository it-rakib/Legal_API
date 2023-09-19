using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DefaultPrescriptionTemplate
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Complain { get; set; }
        public string MedicalHistory { get; set; }
        public string Findings { get; set; }
        public string Diagnosis { get; set; }
        public string Remark { get; set; }
        public string Medicine { get; set; }
        public string Pprocedure { get; set; }
    }
}
