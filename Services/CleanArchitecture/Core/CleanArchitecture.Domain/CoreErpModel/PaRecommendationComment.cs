using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaRecommendationComment
    {
        public long AppraisalMasterId { get; set; }
        public string Comment { get; set; }
        public long CommentBy { get; set; }
        public string CommenterType { get; set; }
        public DateTime? CommentDate { get; set; }
        public int? CommenterDesignationId { get; set; }
    }
}
