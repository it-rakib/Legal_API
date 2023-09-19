using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonGrade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
