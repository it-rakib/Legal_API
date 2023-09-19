using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OpdTicket
    {
        public long Id { get; set; }
        public DateTime TransDate { get; set; }
        public string RegNo { get; set; }
        public string TicketRate { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public int? Opd { get; set; }
        public decimal? Vat { get; set; }
        public int? DoctorId { get; set; }
        public int? DeptId { get; set; }
        public string Room { get; set; }
        public string Comments { get; set; }
        public decimal? Total { get; set; }
        public bool? Posted { get; set; }
        public int? EnteredBy { get; set; }
        public int? QdoctorId { get; set; }
        public string PatientId { get; set; }
        public string ContactNo { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CardAmount { get; set; }
        public decimal? BkashAmount { get; set; }
        public decimal? ChequeAmount { get; set; }
        public string CardName { get; set; }
        public string ChequeNo { get; set; }
        public string Note { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public int? Villageid { get; set; }
        public int? Upzillaid { get; set; }
        public int? Districtid { get; set; }
        public int? ApptSlno { get; set; }
        public int? CorporateClientId { get; set; }
        public int? DivisionId { get; set; }
        public int? UnionId { get; set; }
        public string Status { get; set; }
    }
}
