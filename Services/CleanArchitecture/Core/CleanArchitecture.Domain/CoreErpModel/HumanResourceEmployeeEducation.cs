using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeeEducation
    {
        public int Id { get; set; }
        public long EmpId { get; set; }
        public int DegreeId { get; set; }
        public int PassingYear { get; set; }
        public string Institute { get; set; }
        public int BoardId { get; set; }
        public string Result { get; set; }
        public string OutOf { get; set; }
        public string SubjectName { get; set; }
    }
}
