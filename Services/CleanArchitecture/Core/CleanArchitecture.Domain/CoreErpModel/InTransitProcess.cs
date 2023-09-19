using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class InTransitProcess
    {
        public long Id { get; set; }
        public long EmpId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ProcessName { get; set; }
        public DateTime QueueOn { get; set; }
        public int Status { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
