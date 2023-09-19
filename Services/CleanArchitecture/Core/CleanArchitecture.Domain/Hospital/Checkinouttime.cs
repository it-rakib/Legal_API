using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Checkinouttime
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? CheckTime { get; set; }
        public int? SensorId { get; set; }
    }
}
