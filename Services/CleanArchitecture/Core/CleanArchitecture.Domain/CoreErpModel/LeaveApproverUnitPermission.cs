using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class LeaveApproverUnitPermission
    {
        public long EmpId { get; set; }
        public int UnitId { get; set; }
        public bool? IsActive { get; set; }
    }
}
