using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceApproverDetail
    {
        public long EmpId { get; set; }
        public bool? IsLeaveApprover { get; set; }
        public bool? IsSiteDutyApprover { get; set; }
        public bool? IsInOutApprover { get; set; }
        public bool? IsLeaveForwarder { get; set; }
        public bool? IsSiteDutyForwarder { get; set; }
        public bool? IsInOutForwarder { get; set; }
        public bool? IsLeavePolicyChecker { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
