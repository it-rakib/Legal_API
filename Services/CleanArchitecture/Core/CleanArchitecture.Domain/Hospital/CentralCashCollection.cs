using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CentralCashCollection
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public int? ModuleFlag { get; set; }
        public int? HeadId { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime TransDateCl { get; set; }
        public long? ReferenceId { get; set; }
    }
}
