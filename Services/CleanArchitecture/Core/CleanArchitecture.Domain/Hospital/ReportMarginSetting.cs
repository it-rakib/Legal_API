using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ReportMarginSetting
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public int? TopMargin { get; set; }
        public int? BottomMargin { get; set; }
        public int? LeftMargin { get; set; }
        public int? RightMargin { get; set; }
    }
}
