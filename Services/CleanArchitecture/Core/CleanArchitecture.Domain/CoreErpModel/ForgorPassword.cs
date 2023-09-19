using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ForgorPassword
    {
        public string EmpCode { get; set; }
        public string EmpPassword { get; set; }
        public bool? IsExpired { get; set; }
    }
}
