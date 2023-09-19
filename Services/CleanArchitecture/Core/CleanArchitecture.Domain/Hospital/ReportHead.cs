using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ReportHead
    {
        public int Id { get; set; }
        public string ReportHeadId { get; set; }
        public string ReportHeadName { get; set; }
        public string ReportName { get; set; }
        public bool? Status { get; set; }
    }
}
