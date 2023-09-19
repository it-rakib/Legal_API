using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollEmployeePfdeduction
    {
        public int Pfid { get; set; }
        public long? EmpId { get; set; }
        public decimal? PfamountComp { get; set; }
        public decimal? PfamountEmp { get; set; }
        public int? SalaryYear { get; set; }
        public int? SalaryMonth { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsLocked { get; set; }
    }
}
