using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PmsReviewerRating
    {
        public long EmpId { get; set; }
        public long ReviewerEmpId { get; set; }
        public int RatingPoint { get; set; }
        public string RatingName { get; set; }
        public string Comment { get; set; }
        public bool IsFinal { get; set; }
        public DateTime EntryDate { get; set; }
        public int ReviewMonth { get; set; }
        public int ReviewYear { get; set; }
    }
}
