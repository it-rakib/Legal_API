using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoInvestigation
    {
        public CashMemoInvestigation()
        {
            PatientBiochemistries = new HashSet<PatientBiochemistry>();
        }

        public long Id { get; set; }
        public string PatientName { get; set; }
        public string PatientType { get; set; }
        public string Bed { get; set; }
        public int? AgeYear { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Contact { get; set; }
        public decimal? Total { get; set; }
        public decimal? Discount { get; set; }
        public string DiscountBy { get; set; }
        public decimal? Paid { get; set; }
        public decimal? DuePaid { get; set; }
        public decimal? DueDiscount { get; set; }
        public DateTime? Ddate { get; set; }
        public string RegNo { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? ReportDeliveryDate { get; set; }
        public string PatientId { get; set; }
        public string ReferredSs { get; set; }
        public int? DoctorId { get; set; }
        public int? QdoctorId { get; set; }
        public int? EnteredBy { get; set; }
        public bool? Posted { get; set; }
        public string Remarks { get; set; }
        public bool? DeliveryStatus { get; set; }
        public bool? IsPackage { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public int? CancelledBy { get; set; }
        public int? InvestigationPackageId { get; set; }
        public int? CorporateClientId { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? BkashAmount { get; set; }
        public decimal? ChequeAmount { get; set; }
        public string CardName { get; set; }
        public string ChequeNo { get; set; }
        public string Note { get; set; }
        public string PpNo { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public byte[] BarCode { get; set; }
        public int? AgeYear1 { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public string Email { get; set; }
        public string BankName { get; set; }
        public string Nid { get; set; }
        public string Sender { get; set; }
        public string TransNo { get; set; }
        public string MobileBankName { get; set; }
        public int? NoOfPrint { get; set; }

        public virtual ICollection<PatientBiochemistry> PatientBiochemistries { get; set; }
    }
}
