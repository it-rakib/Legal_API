using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class UnitWiseLetterAcceptPermission
    {
        public int? UnitId { get; set; }
        public int? EmpId { get; set; }
        public bool? IsActive { get; set; }
    }
}
