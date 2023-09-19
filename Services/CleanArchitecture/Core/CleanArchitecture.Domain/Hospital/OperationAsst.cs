using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class OperationAsst
    {
        public int Id { get; set; }
        public long OperationId { get; set; }
        public int DoctorId { get; set; }
    }
}
