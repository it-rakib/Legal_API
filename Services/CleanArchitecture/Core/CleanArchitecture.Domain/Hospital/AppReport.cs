using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class AppReport
    {
        public AppReport()
        {
            AppReportSettings = new HashSet<AppReportSetting>();
        }

        public int Id { get; set; }
        public string Identifire { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AppReportSetting> AppReportSettings { get; set; }
    }
}
