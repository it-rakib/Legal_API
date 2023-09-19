using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class ConferenceRoom
    {
        public ConferenceRoom()
        {
            ConferenceEvents = new HashSet<ConferenceEvent>();
        }

        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public long? UserId { get; set; }
        public int? CommonUnitId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }

        public virtual ICollection<ConferenceEvent> ConferenceEvents { get; set; }
    }
}
