using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaOvarallRating
    {
        public long RatingId { get; set; }
        public long? AppraisalMasterId { get; set; }
        public int? EvalutionId { get; set; }
        public string EvaluationType { get; set; }
        public int? RatingPoint { get; set; }
        public string EvaluationComment { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
