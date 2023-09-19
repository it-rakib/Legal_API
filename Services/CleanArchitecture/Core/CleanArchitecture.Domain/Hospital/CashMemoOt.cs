using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoOt
    {
        public long Id { get; set; }
        public string PatientName { get; set; }
        public string PatientType { get; set; }
        public string Bed { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Contact { get; set; }
        public string PatientId { get; set; }
        public string RegNo { get; set; }
        public int? DoctorId { get; set; }
        public int? Ot { get; set; }
        public decimal Total { get; set; }
        public decimal? Discount { get; set; }
        public string DiscountBy { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
