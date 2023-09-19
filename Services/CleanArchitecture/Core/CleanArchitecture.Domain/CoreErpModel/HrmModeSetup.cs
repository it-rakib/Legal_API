using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HrmModeSetup
    {
        public long UnitId { get; set; }
        public int? HrmmodeId { get; set; }
        public int? EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
