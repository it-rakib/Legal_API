using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonBank
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
    }
}
