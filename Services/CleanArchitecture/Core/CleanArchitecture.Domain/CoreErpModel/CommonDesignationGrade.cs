using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonDesignationGrade
    {
        public int DesignationId { get; set; }
        public int? UnitTypeId { get; set; }
        public int? GradeId { get; set; }
    }
}
