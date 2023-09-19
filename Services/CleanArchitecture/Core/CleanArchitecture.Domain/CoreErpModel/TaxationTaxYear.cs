using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TaxationTaxYear
    {
        public int TaxYearId { get; set; }
        public string FiscalYear { get; set; }
        public string TaxType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
