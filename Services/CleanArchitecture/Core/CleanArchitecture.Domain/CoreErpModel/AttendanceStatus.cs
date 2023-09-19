using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceStatus
    {
        public int AttStatusId { get; set; }
        public string AttStatusName { get; set; }
        public string AttStatusShort { get; set; }
        public string GraphColor { get; set; }
    }
}
