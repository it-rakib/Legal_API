using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ConferenceEventParticipate
    {
        public int EventParticipateId { get; set; }
        public int EventId { get; set; }
        public long EmpId { get; set; }

        public virtual HumanResourceEmployeeBasic Emp { get; set; }
        public virtual ConferenceEvent Event { get; set; }
    }
}
