using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeePhoto
    {
        public long Id { get; set; }
        public long EmpId { get; set; }
        public byte[] Photo { get; set; }
    }
}
