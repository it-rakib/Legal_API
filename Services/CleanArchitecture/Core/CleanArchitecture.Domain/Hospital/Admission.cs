using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Admission
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public string PatientId { get; set; }
        public int? Department { get; set; }
        public string Diagnosis { get; set; }
        public string Age { get; set; }
        public int? ReferredBy { get; set; }
        public int? Consultant { get; set; }
        public int? AdmittedBy { get; set; }
        public bool? IsReferred { get; set; }
        public int? BedCabinId { get; set; }
        public decimal? AdmissionFee { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool? IsAdmitted { get; set; }
        public DateTime? BedAdmissionDate { get; set; }
        public string Comments { get; set; }
        public long? BillNo { get; set; }
        public int? BillGeneratedBy { get; set; }
        public int? MpoId { get; set; }
        public bool? IsPackage { get; set; }
        public DateTime? TransDate { get; set; }
        public int? EnteredBy { get; set; }
        public decimal? Ambulance { get; set; }
        public string Outcome { get; set; }
        public string PatientCategory { get; set; }
        public int? PatientReceivedBy { get; set; }
        public DateTime? PatientReceivedDate { get; set; }
        public byte[] BarCodeImage { get; set; }
        public int? DoctorId { get; set; }
        public int? BedCabinCatId { get; set; }
        public DateTime? OtDate { get; set; }
        public int? OpdPackage { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Due { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public int? BedRate { get; set; }
    }
}
