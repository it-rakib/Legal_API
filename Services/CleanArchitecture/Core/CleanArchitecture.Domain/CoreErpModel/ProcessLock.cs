using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ProcessLock
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int PayrollTypeId { get; set; }
        public int Lmonth { get; set; }
        public int Lyear { get; set; }
        public DateTime LockDate { get; set; }
    }
}
