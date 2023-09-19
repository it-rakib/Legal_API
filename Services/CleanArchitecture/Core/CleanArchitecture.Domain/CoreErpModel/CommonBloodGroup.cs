using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonBloodGroup
    {
        public int BloodGroupId { get; set; }
        public string BloodGroupName { get; set; }
        public string BloodGroupNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
