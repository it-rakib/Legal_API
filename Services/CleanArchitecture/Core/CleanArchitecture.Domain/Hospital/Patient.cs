using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Patient
    {
        public long Id { get; set; }
        public string PatientId { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string BloodGroup { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string CareOf { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string District { get; set; }
        public string PermanentVillage { get; set; }
        public string PermanentPo { get; set; }
        public string PermanentPs { get; set; }
        public string PermanentDistrict { get; set; }
        public string PresentVillage { get; set; }
        public string PresentPo { get; set; }
        public string PresentPs { get; set; }
        public string PresentDistrict { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? TransDate { get; set; }
        public byte[] BarCodeImage { get; set; }
        public int? CorporateClientId { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public int? PatientCatId { get; set; }
        public string Remarks { get; set; }
    }
}
