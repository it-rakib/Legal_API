using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class TempPunchRecord
    {
        public int PunchNo { get; set; }
        public DateTime PunchTime { get; set; }
        public string DeviceNo { get; set; }
        public string Remarks { get; set; }
        public string Manually { get; set; }
        public string Status { get; set; }
    }
}
