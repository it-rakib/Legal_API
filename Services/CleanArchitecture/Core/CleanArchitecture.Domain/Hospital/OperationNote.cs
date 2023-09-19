using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OperationNote
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string ProcedureAndFindings { get; set; }
        public string Operation { get; set; }
        public string Indication { get; set; }
        public DateTime OperationDate { get; set; }
        public int? Surgeon { get; set; }
        public int? Assistant { get; set; }
        public int? Assistant2 { get; set; }
        public int? Assistant3 { get; set; }
        public int? Anaesthesist { get; set; }
        public string Anaesthesia { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
