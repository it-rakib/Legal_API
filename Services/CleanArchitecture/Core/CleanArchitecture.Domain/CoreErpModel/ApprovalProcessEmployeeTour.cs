using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ApprovalProcessEmployeeTour
    {
        public long Id { get; set; }
        public long Sdid { get; set; }
        public long? FromEmpId { get; set; }
        public long? ToEmpId { get; set; }
        public byte? ActionStatus { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Remarks { get; set; }
    }
}
