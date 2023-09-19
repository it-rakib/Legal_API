using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class RDepDesignation
    {
        public int DepDesignationId { get; set; }
        public int? UdepId { get; set; }
        public int? DesignationId { get; set; }
    }
}
