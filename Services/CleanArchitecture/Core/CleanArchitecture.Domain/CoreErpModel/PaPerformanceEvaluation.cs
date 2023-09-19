using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaPerformanceEvaluation
    {
        public int CategoryId { get; set; }
        public string RatingName { get; set; }
        public string CategoryDescription { get; set; }
        public bool? IsActive { get; set; }
        public int? RatingPointMaxRange { get; set; }
        public int? SerialNo { get; set; }
    }
}
