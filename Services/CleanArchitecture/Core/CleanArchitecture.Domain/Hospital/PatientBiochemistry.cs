using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientBiochemistry
    {
        public long Id { get; set; }
        public long? MemoId { get; set; }
        public int? HeadBiochemistryId { get; set; }
        public string Result { get; set; }
        public string HeadName { get; set; }

        public virtual CashMemoInvestigation Memo { get; set; }
    }
}
