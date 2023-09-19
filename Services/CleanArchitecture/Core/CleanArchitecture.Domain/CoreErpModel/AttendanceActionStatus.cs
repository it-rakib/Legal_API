using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceActionStatus
    {
        public int ActionStatusId { get; set; }
        public string ActionStatusName { get; set; }
        public bool? IsActive { get; set; }
    }
}
