using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class RecruitmentVacancy
    {
        public int VacancyId { get; set; }
        public string JobTitle { get; set; }
        public string JobRef { get; set; }
        public string JobDescription { get; set; }
        public int? NoOfPosition { get; set; }
        public string JobLocation { get; set; }
        public int? UnitId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// 0=Published, 1=UnPublished,3=Closed
        /// </summary>
        public int? Status { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
    }
}
