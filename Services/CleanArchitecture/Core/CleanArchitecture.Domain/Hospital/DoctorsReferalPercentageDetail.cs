using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DoctorsReferalPercentageDetail
    {
        public long Id { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int? ServiceId { get; set; }
        public int? DoctorsId { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? PercentageLs { get; set; }
        public int? EnteredBy { get; set; }
    }
}
