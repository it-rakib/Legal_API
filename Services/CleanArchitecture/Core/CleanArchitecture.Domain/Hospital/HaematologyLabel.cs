using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class HaematologyLabel
    {
        public int Id { get; set; }
        public string Label1 { get; set; }
        public string Label2 { get; set; }
        public string Result1 { get; set; }
        public string Result2 { get; set; }
        public string PatientId { get; set; }
        public string MemoId { get; set; }
    }
}
