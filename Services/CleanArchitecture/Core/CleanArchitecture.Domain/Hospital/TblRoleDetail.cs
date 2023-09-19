using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TblRoleDetail
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string TaskId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
    }
}
