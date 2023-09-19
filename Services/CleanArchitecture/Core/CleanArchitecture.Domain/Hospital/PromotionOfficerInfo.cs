using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PromotionOfficerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Incentiverate { get; set; }
        public string Addesss { get; set; }
        public decimal? PathoRate { get; set; }
        public decimal? XrayRate { get; set; }
        public decimal? UsgRate { get; set; }
        public decimal? EcgRate { get; set; }
        public decimal? CtscanRate { get; set; }
        public decimal? MriRate { get; set; }
        public decimal? EttRate { get; set; }
        public decimal? CdoplerRate { get; set; }
        public decimal? ColonosRate { get; set; }
        public decimal? EndosRate { get; set; }
        public decimal? EegRate { get; set; }
        public decimal? OpgRate { get; set; }
        public decimal? EchoRate { get; set; }
        public decimal? Echo2dRate { get; set; }
        public decimal? BmdRate { get; set; }
        public decimal? CturoRate { get; set; }
        public decimal? EflowRate { get; set; }
    }
}
