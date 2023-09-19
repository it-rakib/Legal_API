using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonPaymentMode
    {
        public int PaymentModeId { get; set; }
        public string PaymentModeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
