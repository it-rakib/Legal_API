using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeClearanceM
    {
        public int ClearanceId { get; set; }
        public int EmpId { get; set; }
        public int? ResponsiblePerson { get; set; }
        public DateTime? ClearanceDate { get; set; }
        public bool? ClearStatus { get; set; }
        public string EntryUserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string TerminalId { get; set; }
    }
}
