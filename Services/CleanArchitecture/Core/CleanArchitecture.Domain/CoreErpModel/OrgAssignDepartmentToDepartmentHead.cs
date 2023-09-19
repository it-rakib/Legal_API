using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class OrgAssignDepartmentToDepartmentHead
    {
        public long EmpId { get; set; }
        public int DepartmentId { get; set; }
    }
}
