using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeePromotionInfo
    {
        public int PromotionId { get; set; }
        public DateTime EffectDate { get; set; }
        public int EmpId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int? DesignationId { get; set; }
        public int? DesignationSpecId { get; set; }
        public int? EmpTypeId { get; set; }
        public int? CalculationFormulaId { get; set; }
        public decimal? Benefit { get; set; }
        public string Note { get; set; }
        public DateTime? EntryDate { get; set; }
        public string UserId { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string TerminalId { get; set; }
        public bool? IsLocked { get; set; }
    }
}
