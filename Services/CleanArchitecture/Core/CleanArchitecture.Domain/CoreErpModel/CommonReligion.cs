using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonReligion
    {
        public int ReligionId { get; set; }
        public string ReligionName { get; set; }
        public string ReligionNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
