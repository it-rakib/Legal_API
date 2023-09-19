using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TaxationAllowedInvestment
    {
        public int AllowInvestmentId { get; set; }
        public int TaxYearId { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? TaxableIncomePer { get; set; }
        public decimal? TaxCreditRate { get; set; }
        public decimal? MaxAllowedInvestmentAmt { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
