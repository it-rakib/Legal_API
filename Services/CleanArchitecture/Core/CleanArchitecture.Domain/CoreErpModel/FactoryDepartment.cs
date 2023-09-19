using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class FactoryDepartment
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int UnitId { get; set; }
        public int CompanyId { get; set; }
    }
}
