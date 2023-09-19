using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Prescription
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? PatientId { get; set; }
        public string Age { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public string Sex { get; set; }
        public string BloodGroup { get; set; }
        public int? VisitNo { get; set; }
        public DateTime? VisitDate { get; set; }
        public string Type { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string Bmi { get; set; }
        public string Prem { get; set; }
        public string Pulse { get; set; }
        public string Restp { get; set; }
        public string Bp { get; set; }
        public string Temperature { get; set; }
        public string Waist { get; set; }
        public string Hip { get; set; }
        public string Complain { get; set; }
        public string MedicalHistory { get; set; }
        public string Findings { get; set; }
        public string Diagnosis { get; set; }
        public string Investigation { get; set; }
        public string Remark { get; set; }
        public string Medicine { get; set; }
        public int? ReferredBy { get; set; }
        public string Pprocedure { get; set; }
        public DateTime? NextVisit { get; set; }
        public string DozeTime { get; set; }
        public string Remarks { get; set; }
        public string RefId { get; set; }
        public string AppointmentFor { get; set; }
        public decimal? Rate { get; set; }
        public int? EnteredBy { get; set; }
        public string DoctorAdvices { get; set; }
        public string ContactNo { get; set; }
        public string Anaemai { get; set; }
        public string Jaundice { get; set; }
        public string Oe { get; set; }
        public string Ho { get; set; }
        public int? ServiceId { get; set; }
    }
}
