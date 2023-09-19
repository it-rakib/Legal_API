using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ChequeRegistration
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public int Bank { get; set; }
        public string PayTo { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string Remark { get; set; }
        public string EnteredBy { get; set; }
    }
}
