using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PmsReviewShedule
    {
        public long EmpId { get; set; }
        public int ReviewMonth { get; set; }
        public int ReviewYear { get; set; }
        public bool? IsReview { get; set; }
        public bool? IsEmail { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
