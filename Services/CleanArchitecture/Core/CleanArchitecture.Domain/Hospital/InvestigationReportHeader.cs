using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class InvestigationReportHeader
    {
        public int Id { get; set; }
        public int InvestigationModuleId { get; set; }
        public string MechineText { get; set; }
        public int? ConsultantId { get; set; }
        public int? CheckedById { get; set; }
    }
}
