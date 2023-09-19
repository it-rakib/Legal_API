using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TempDistanceAllowance
    {
        public string EmpCode { get; set; }
        public bool? IsProcess { get; set; }
        public int? IsActive { get; set; }
    }
}
