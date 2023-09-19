using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ClearanceApprovalAccess
    {
        public int EmpId { get; set; }
        public DateTime? EffectDate { get; set; }
    }
}
