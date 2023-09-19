using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaySlipOpen
    {
        public int Id { get; set; }
        public int? PayrollTypeId { get; set; }
        public int? SalaryMonth { get; set; }
        public int? SalaryYear { get; set; }
        public bool? IsOpened { get; set; }
        public DateTime? OpenDate { get; set; }
        public int? OpenBy { get; set; }
    }
}
