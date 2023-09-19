using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TblPaymentMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Createby { get; set; }
        public DateTime? Createdat { get; set; }
        public string Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
