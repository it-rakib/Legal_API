using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceProcessSetupOt
    {
        public int UnitId { get; set; }
        public int SalaryMonth { get; set; }
        public int SalaryYear { get; set; }
        public int? Othour { get; set; }
    }
}
