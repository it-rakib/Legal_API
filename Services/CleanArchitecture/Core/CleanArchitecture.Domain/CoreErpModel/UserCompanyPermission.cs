using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class UserCompanyPermission
    {
        public int UserId { get; set; }
        public int CompanyId { get; set; }
    }
}
