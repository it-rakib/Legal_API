using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ServiceCategorySubDinvestigation
    {
        public int Id { get; set; }
        public int MasterCategoryId { get; set; }
        public int ChildCategoryId { get; set; }
    }
}
