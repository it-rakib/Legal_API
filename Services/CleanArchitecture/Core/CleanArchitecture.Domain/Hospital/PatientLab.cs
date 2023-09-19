using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientLab
    {
        public int Id { get; set; }
        public long MemoId { get; set; }
        public string Title { get; set; }
        public string Result { get; set; }
        public int? LabModuleId { get; set; }
        public string ReportHeader { get; set; }
    }
}
