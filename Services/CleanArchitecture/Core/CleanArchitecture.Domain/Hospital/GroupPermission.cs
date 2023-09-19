using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class GroupPermission
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public int GroupId { get; set; }
    }
}
