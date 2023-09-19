using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AppReportSetting
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public string Settings { get; set; }
        public string Value { get; set; }

        public virtual AppReport Report { get; set; }
    }
}
