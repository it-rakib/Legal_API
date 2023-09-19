using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DoctorsProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameB { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public string DegreePres { get; set; }
        public string DegreePresB { get; set; }
        public string Attachment { get; set; }
        public int? PoSerial { get; set; }
        public int? AreaCode { get; set; }
        public decimal? Balance { get; set; }
        public decimal? OpeningBalance { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Room { get; set; }
        public int? Department { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? TransDate { get; set; }
        public string Address { get; set; }
        public decimal? PathoRate { get; set; }
        public decimal? SpPathoRate { get; set; }
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
        public int? ReferralCategoryId { get; set; }
        public string Degree2 { get; set; }
        public int? Status { get; set; }
        public string BmaReg { get; set; }
        public string DoctorCode { get; set; }
        public string VisitingHour { get; set; }
        public decimal? CtscanRate7k { get; set; }
        public decimal? CtscanRate10k { get; set; }
        public int? TicketTypeId { get; set; }
        public string SmsDoctorName { get; set; }
    }
}
