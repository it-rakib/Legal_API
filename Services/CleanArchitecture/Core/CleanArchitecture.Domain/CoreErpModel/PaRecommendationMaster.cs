using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaRecommendationMaster
    {
        public long AppraisalMasterId { get; set; }
        public long EmpId { get; set; }
        public int RecommendationValue { get; set; }
    }
}
