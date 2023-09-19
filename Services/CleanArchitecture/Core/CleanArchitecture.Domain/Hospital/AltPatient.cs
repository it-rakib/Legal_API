using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AltPatient
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int DoctorId { get; set; }
        public string PatientCategory { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public string DiscountBy { get; set; }
        public decimal NetAmount { get; set; }
        public decimal Advance { get; set; }
        public decimal Paid { get; set; }
        public bool? IsPosted { get; set; }
        public int? NoOfPrint { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? MobileAmount { get; set; }
        public decimal? ChequeAmount { get; set; }
        public string CardName { get; set; }
        public string ChequeNo { get; set; }
        public string BankName { get; set; }
        public string MobileBankingName { get; set; }
    }
}
