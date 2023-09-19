using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicalCertificate
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public string Suffering { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? DoctorId { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
