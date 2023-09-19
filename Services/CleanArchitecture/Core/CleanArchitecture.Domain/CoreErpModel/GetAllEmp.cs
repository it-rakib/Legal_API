using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class GetAllEmp
    {
        public int EmpId { get; set; }
        public string EmpCode { get; set; }
        public string Name { get; set; }
        public DateTime? JoiningDate { get; set; }
    }
}
