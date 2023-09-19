using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollDistanceAllowance
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int? DesignationId { get; set; }
        public int SalaryYear { get; set; }
        public int SalaryMonth { get; set; }
        public int CostHeadId { get; set; }
        public decimal? PayableDays { get; set; }
        public decimal? AllowanceRate { get; set; }
        public decimal? AllowanceAmount { get; set; }
        public int? PayrollCompanyId { get; set; }
        public int? ProcessBy { get; set; }
        public DateTime? ProcessDate { get; set; }
        public bool? UnPaid { get; set; }
    }
}
