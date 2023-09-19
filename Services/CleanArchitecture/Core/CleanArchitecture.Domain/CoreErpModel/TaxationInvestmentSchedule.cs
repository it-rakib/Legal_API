using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TaxationInvestmentSchedule
    {
        public int InvestmentTypeId { get; set; }
        public string InvestmentTypeName { get; set; }
        public decimal? InvestmentAmount { get; set; }
        public int? TaxYearId { get; set; }
        public bool? IsActive { get; set; }
    }
}
