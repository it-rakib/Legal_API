using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonBoard
    {
        public int BoardId { get; set; }
        public string BoardName { get; set; }
        public bool? IsActive { get; set; }
    }
}
