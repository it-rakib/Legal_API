using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceProcessQueue
    {
        public long QueueId { get; set; }
        public int PunchNo { get; set; }
        public DateTime PunchDate { get; set; }
        public DateTime QueuedDate { get; set; }
        public bool? IsProcessed { get; set; }
        public DateTime? ProcessedTime { get; set; }
        public string Dbname { get; set; }
    }
}
