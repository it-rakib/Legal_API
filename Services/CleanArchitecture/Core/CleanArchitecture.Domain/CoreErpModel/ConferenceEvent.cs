using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ConferenceEvent
    {
        public ConferenceEvent()
        {
            ConferenceEventParticipates = new HashSet<ConferenceEventParticipate>();
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public string Remarks { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsRejected { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ConferenceRoom Room { get; set; }
        public virtual ICollection<ConferenceEventParticipate> ConferenceEventParticipates { get; set; }
    }
}
