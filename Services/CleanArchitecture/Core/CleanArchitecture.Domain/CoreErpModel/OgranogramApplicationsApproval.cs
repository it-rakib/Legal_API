using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class OgranogramApplicationsApproval
    {
        public long EmpId { get; set; }
        public long SupervisorEmpId { get; set; }
        public DateTime EffectDate { get; set; }
        public int? SuperiorOrder { get; set; }
        public bool? IsActive { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? InActiveDate { get; set; }
        public long? InActiveBy { get; set; }
        public int? ProjectId { get; set; }
    }
}
