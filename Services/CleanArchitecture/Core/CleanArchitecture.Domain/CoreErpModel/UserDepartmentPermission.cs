using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class UserDepartmentPermission
    {
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
    }
}
