using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Housekeepissue
    {
        public int Id { get; set; }
        public string IssueNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueToPerson { get; set; }
        public string Remarks { get; set; }
        public int? EnteredBy { get; set; }
    }
}
