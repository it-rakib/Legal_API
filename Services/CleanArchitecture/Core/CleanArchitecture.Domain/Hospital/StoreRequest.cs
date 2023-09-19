using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreRequest
    {
        public int StoreRequestId { get; set; }
        public DateTime? TransDate { get; set; }
        public string RequestFrom { get; set; }
        public int? RequestDepartment { get; set; }
        public string ReqNo { get; set; }
        public int? EnterdBy { get; set; }
        public int? StoreId { get; set; }
        public bool? IsIssued { get; set; }
        public string ReqBy { get; set; }
        public string Remark { get; set; }
    }
}
