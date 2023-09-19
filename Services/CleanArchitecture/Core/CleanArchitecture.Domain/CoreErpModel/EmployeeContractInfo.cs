using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeContractInfo
    {
        public int ContractId { get; set; }
        public long EmpId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public int? IncrementTypeId { get; set; }
        public decimal? PreviousSalary { get; set; }
        public decimal? FixAmount { get; set; }
        public decimal? NewGrossSalary { get; set; }
        public string Note { get; set; }
        public long? RefId { get; set; }
        public int? UserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsLocked { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
    }
}
