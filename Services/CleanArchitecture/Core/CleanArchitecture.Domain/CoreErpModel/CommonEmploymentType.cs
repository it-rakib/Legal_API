using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonEmploymentType
    {
        public int EmpTypeId { get; set; }
        public string EmpTypeName { get; set; }
        public string EmpTypeNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
