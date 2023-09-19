using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class LetterPrintHistory
    {
        public int PrintId { get; set; }
        public int? LetterTypeId { get; set; }
        public DateTime? LetterPrintDate { get; set; }
        public long? EmpId { get; set; }
        public int? PrintBy { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
