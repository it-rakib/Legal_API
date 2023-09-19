using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class SettingCmiSm
    {
        public int CmiSmsId { get; set; }
        public string CmiSmsText { get; set; }
        public bool? CmiSmsYes { get; set; }
        public string CmiAdminNo { get; set; }
        public string PadmissionText { get; set; }
        public bool? PadmissionSmsYes { get; set; }
        public string PadmissionAdminNo { get; set; }
    }
}
