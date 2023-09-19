using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonCurrency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal? CurrencyRate { get; set; }
        public bool? IsActive { get; set; }
    }
}
