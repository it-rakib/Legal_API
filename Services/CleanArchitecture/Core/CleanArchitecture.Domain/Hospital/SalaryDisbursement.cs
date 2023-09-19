using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class SalaryDisbursement
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public DateTime DisbursementMonth { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Basic { get; set; }
        public decimal? HouseRent { get; set; }
        public decimal? Medical { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Da { get; set; }
        public decimal? Special { get; set; }
        public decimal? Washing { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? ServiceCharge { get; set; }
        public string Remarks { get; set; }
        public int? EnterBy { get; set; }
    }
}
