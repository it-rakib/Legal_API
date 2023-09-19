using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonBranch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int BankId { get; set; }
        public string AccountFormat { get; set; }
        public string RoutingNo { get; set; }
        public bool? IsActive { get; set; }
    }
}
