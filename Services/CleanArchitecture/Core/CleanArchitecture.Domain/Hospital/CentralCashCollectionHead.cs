using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CentralCashCollectionHead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int? VoucherHeadId { get; set; }
    }
}
