using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TaxationEmployeeInvestment
    {
        public int InvestmentId { get; set; }
        public long? EmpId { get; set; }
        public int? TaxYearId { get; set; }
        public int? InvestmentTypeId { get; set; }
        public decimal? InvestmentAmount { get; set; }
    }
}
