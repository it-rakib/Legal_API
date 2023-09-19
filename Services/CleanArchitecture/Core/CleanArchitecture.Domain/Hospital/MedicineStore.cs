using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBufferStore { get; set; }
        public bool? IsActive { get; set; }
    }
}
