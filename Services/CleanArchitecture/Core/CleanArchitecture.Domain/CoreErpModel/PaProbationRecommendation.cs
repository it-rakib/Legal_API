using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaProbationRecommendation
    {
        public long AppraisalMasterId { get; set; }
        public long EmpId { get; set; }
        public int? ProbationMonth { get; set; }
        public DateTime? EffectDate { get; set; }
    }
}
