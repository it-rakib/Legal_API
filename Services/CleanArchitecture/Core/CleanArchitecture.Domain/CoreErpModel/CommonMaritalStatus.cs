using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonMaritalStatus
    {
        public int MaritalStatusId { get; set; }
        public string MaritalStatusName { get; set; }
        public string MaritalStatusNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
