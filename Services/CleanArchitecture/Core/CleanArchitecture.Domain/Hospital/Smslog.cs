using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Smslog
    {
        public int SmsLogId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string MobileNo { get; set; }
        public string AreaName { get; set; }
        public string RefferedBy { get; set; }
        public string SenderMobileNo { get; set; }
        public int? EnteredBy { get; set; }
        public string UserName { get; set; }
        public int? MemoId { get; set; }
    }
}
