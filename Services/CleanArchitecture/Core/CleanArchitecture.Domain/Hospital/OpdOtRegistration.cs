using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OpdOtRegistration
    {
        public long Id { get; set; }
        public DateTime TransDate { get; set; }
        public string PatientId { get; set; }
        public string RegNo { get; set; }
        public DateTime? RegDate { get; set; }
        public string Name { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public string ContactNo { get; set; }
        public string Sex { get; set; }
        public string StaffRef { get; set; }
        public string EmployeeId { get; set; }
        public int? DoctorId { get; set; }
        public string Room { get; set; }
        public int? ApptSlno { get; set; }
        public int? DeptId { get; set; }
        public int? ServiceId { get; set; }
        public decimal? Package { get; set; }
        public decimal? Otcharge { get; set; }
        public decimal? Gas { get; set; }
        public decimal? Pow { get; set; }
        public decimal? Monitor { get; set; }
        public decimal? Machine { get; set; }
        public decimal? Surgeon { get; set; }
        public decimal? Anesthetist { get; set; }
        public decimal? Asstfee1 { get; set; }
        public decimal? Asstfee2 { get; set; }
        public decimal? Asstfee3 { get; set; }
        public decimal? Others { get; set; }
        public string Comments { get; set; }
        public bool? Posted { get; set; }
        public int? EnteredBy { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Paid { get; set; }
        public string Roomno { get; set; }
        public string Bedno { get; set; }
        public decimal? Medicine { get; set; }
        public int? Billno { get; set; }
    }
}
