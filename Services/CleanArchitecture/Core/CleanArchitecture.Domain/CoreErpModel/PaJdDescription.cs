using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class PaJdDescription
    {
        public long JddescriptionId { get; set; }
        public long EmpId { get; set; }
        public long AppraisalMasterId { get; set; }
        public string Jddescription { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
