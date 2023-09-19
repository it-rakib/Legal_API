using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonEmploymentStatus
    {
        public int EmpStatusId { get; set; }
        public string EmpStatusName { get; set; }
        public string EmpStatusNameBan { get; set; }
        public bool IsPartial { get; set; }
        public bool? IsActive { get; set; }
    }
}
