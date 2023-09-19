using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TempTaxInfo
    {
        public string EmpCode { get; set; }
        public decimal? TaxAmtComp { get; set; }
        public decimal? TaxAmtEmp { get; set; }
    }
}
