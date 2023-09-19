using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class InvestigationModule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Remark { get; set; }
        public string Comments { get; set; }
        public string ReportHeader { get; set; }
    }
}
