using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PayrollCurrencyConversion
    {
        public long ConId { get; set; }
        public int CurrencyId { get; set; }
        public decimal ConversionRate { get; set; }
        public int SalaryMonth { get; set; }
        public int SalaryYear { get; set; }
    }
}
