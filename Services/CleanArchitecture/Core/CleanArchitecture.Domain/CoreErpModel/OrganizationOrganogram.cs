using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class OrganizationOrganogram
    {
        public long EmpId { get; set; }
        public long? SupervisorId { get; set; }
    }
}
