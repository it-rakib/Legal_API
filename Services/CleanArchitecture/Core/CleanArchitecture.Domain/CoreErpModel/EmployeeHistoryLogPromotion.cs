using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeHistoryLogPromotion
    {
        public int LogId { get; set; }
        public int EmpId { get; set; }
        public DateTime LogDate { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int? DesignationId { get; set; }
        public int? DesignationSpecId { get; set; }
        public int? EmpTypeId { get; set; }
        public int? CalculationFormulaId { get; set; }
        public int? PromotionId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UserId { get; set; }
    }
}
