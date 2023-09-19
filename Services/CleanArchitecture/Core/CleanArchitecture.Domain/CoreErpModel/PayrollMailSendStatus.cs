using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollMailSendStatus
    {
        public long? EmpId { get; set; }
        public int? SalaryMonth { get; set; }
        public int? SalaryYear { get; set; }
        public int? IsSend { get; set; }
    }
}
