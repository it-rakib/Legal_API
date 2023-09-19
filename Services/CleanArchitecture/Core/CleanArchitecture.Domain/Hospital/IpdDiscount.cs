using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class IpdDiscount
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public decimal? DiscountHospital { get; set; }
        public decimal? DiscountDoctor { get; set; }
        public string DiscountHospitalBy { get; set; }
        public string DiscountDoctorBy { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
