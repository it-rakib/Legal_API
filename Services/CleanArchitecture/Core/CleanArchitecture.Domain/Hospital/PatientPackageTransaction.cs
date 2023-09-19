using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientPackageTransaction
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public int ServiceId { get; set; }
        public decimal ServiceRate { get; set; }
        public decimal Quantity { get; set; }
        public int? IpdDeptId { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
    }
}
