using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TaxYear
    {
        public int TaxYearId { get; set; }
        public byte Syear { get; set; }
        public byte Eyear { get; set; }
    }
}
