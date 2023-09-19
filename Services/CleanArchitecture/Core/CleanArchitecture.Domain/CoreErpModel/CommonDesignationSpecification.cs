using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonDesignationSpecification
    {
        public int DesignationSpecId { get; set; }
        public string DesignationSpecification { get; set; }
        public string DesignationSpecificationBan { get; set; }
        public int IsActive { get; set; }
        public int? UserId { get; set; }
        public string TerminalId { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
