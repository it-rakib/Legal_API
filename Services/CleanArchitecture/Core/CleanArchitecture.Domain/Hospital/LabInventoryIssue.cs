using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabInventoryIssue
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
