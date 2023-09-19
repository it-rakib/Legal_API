using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class EmployeeInfo
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Department { get; set; }
        public int? Designation { get; set; }
        public string Religion { get; set; }
        public string Status { get; set; }
        public string AcNo { get; set; }
        public string AttendanceMediaId { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Basic { get; set; }
        public decimal? HouseRent { get; set; }
        public decimal? Medical { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Da { get; set; }
        public decimal? Special { get; set; }
        public decimal? Washing { get; set; }
        public decimal? Bonus { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string Experiance { get; set; }
        public DateTime? IncrementDate { get; set; }
        public string PayScale { get; set; }
        public byte[] Photo { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string InActiveStatus { get; set; }
        public string Reason { get; set; }
        public decimal? FinancialBenifit { get; set; }
        public decimal? MonthlySalary { get; set; }
        public decimal? SalaryAdjustment { get; set; }
        public decimal? Gffund { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public int? PayMode { get; set; }
        public int? WorkShiftId { get; set; }
        public string Nid { get; set; }
        public string Sex { get; set; }
        public bool? IsNid { get; set; }
        public bool? IsBirthCertificate { get; set; }
        public bool? IsAcademicCertificate { get; set; }
        public bool? IsTinCertificate { get; set; }
        public bool? IsExperienceCertificate { get; set; }
        public bool? IsProfessionalCertificate { get; set; }
        public string Sopuse { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? FoodAllowance { get; set; }
        public int? PermanentVillage { get; set; }
        public int? PermanentPo { get; set; }
        public int? PermanentPs { get; set; }
        public int? PermanentDistrict { get; set; }
        public int? PresentVillage { get; set; }
        public int? PresentPo { get; set; }
        public int? PresentPs { get; set; }
        public int? PresentDistrict { get; set; }
        public int? PermanentDivision { get; set; }
        public int? PresentDivision { get; set; }
        public string BloodGroup { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? Arrear { get; set; }
    }
}
