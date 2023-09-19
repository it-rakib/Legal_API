using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollSalaryHead
    {
        public int SalaryHeadId { get; set; }
        public string SalaryHead { get; set; }
        public string ShortName { get; set; }
        public bool? IsActive { get; set; }
    }
}
