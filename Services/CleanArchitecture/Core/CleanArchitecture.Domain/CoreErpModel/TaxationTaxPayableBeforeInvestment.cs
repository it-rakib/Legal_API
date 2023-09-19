using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TaxationTaxPayableBeforeInvestment
    {
        public int TaxPayableId { get; set; }
        public int? TaxYearId { get; set; }
        public int? CategoryId { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? TaxRate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
