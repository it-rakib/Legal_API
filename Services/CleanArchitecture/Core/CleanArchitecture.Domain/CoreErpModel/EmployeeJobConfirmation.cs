using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmployeeJobConfirmation
    {
        public int ConfirmationId { get; set; }
        public long? EmpId { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
    }
}
