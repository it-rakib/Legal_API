using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OperationList
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public string Otprocedure { get; set; }
        public string Operation { get; set; }
        public string Anaesthesia { get; set; }
        public int? Anasthetist { get; set; }
        public int Operator { get; set; }
        public string Comments { get; set; }
        public DateTime OperationDate { get; set; }
        public string Drug { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public bool? Otdone { get; set; }
        public int? OtSlNo { get; set; }
    }
}
