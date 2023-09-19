using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class UserTeamPermission
    {
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int WingId { get; set; }
        public int TeamId { get; set; }
    }
}
