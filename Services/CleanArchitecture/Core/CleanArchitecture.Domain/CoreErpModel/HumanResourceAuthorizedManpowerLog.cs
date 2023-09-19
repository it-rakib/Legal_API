using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceAuthorizedManpowerLog
    {
        public long AuthorizeId { get; set; }
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int? WingId { get; set; }
        public int? TeamId { get; set; }
        public int? DesignationId { get; set; }
        public int? DesignationGroupId { get; set; }
        public int? Manpower { get; set; }
        public DateTime? EffectDate { get; set; }
        public DateTime? PreEntryDate { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
