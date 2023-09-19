using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonPosition
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public string PositionNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
