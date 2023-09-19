using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoDinvestigation
    {
        public long Id { get; set; }
        public string PatientName { get; set; }
        public string PatientType { get; set; }
        public string Bed { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Contact { get; set; }
        public decimal Total { get; set; }
        public decimal? Discount { get; set; }
        public string DiscountBy { get; set; }
        public decimal Paid { get; set; }
        public string RegNo { get; set; }
        public DateTime? TransDate { get; set; }
        public string PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int? ModuleId { get; set; }
        public int? EnteredBy { get; set; }
        public string Remarks { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? BkashAmount { get; set; }
        public decimal? ChequeAmount { get; set; }
        public string CardName { get; set; }
        public string ChequeNo { get; set; }
        public string Note { get; set; }
        public decimal? DueDiscount { get; set; }
        public decimal? DuePaid { get; set; }
        public DateTime? Ddate { get; set; }
        public int? QdoctorId { get; set; }
        public string RefId { get; set; }
        public int? PoSerial { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public int? NoOfPrint { get; set; }
    }
}
