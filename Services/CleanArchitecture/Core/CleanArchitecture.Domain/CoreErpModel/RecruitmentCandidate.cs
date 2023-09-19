using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class RecruitmentCandidate
    {
        public int CandidateId { get; set; }
        public int? VacancyId { get; set; }
        public string CandidateName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public DateTime? AppliedDate { get; set; }
        public string ResumePath { get; set; }
        /// <summary>
        /// 0=Application Received, 1=ShortListed, 2=Interview, 3=Job Offer, 4=Hired, 5=Rejected
        /// </summary>
        public int? Stage { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
    }
}
