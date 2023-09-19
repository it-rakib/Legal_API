using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class UserUnitPermission
    {
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
    }
}
