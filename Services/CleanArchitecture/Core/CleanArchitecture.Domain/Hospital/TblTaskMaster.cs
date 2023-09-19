using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TblTaskMaster
    {
        public string Id { get; set; }
        public string TaskName { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string ParentId { get; set; }
        public string ForAll { get; set; }
        public string Icon { get; set; }
        public int? Slno { get; set; }
    }
}
