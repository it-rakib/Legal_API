using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonJobLocation
    {
        public int JobLocationId { get; set; }
        public string JobLocationName { get; set; }
        public string JobLocationNameBan { get; set; }
        public string JobLocationShortName { get; set; }
        public string JobLocationAddress { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
        public string TerminalId { get; set; }
        public int? SortOrder { get; set; }
    }
}
