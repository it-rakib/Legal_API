using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaReDesignatedRecommendation
    {
        public long AppraisalMasterId { get; set; }
        public long? EmpId { get; set; }
        public int? PromotedDesignationId { get; set; }
        public DateTime? EffectDate { get; set; }
    }
}
