using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ParticularsMasterHead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? ActypeId { get; set; }
        public long? AcSlNo { get; set; }
        public int? BalanceSheetHeadId { get; set; }
    }
}
