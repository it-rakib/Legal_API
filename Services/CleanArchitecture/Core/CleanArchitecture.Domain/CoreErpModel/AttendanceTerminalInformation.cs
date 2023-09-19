using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AttendanceTerminalInformation
    {
        public long? UnitId { get; set; }
        public string ControllerId { get; set; }
        public string IpAddress { get; set; }
        public long? Port { get; set; }
        public long? Password { get; set; }
        public string ReaderType { get; set; }
        public string Location { get; set; }
        /// <summary>
        /// LocationID=JobLocationID
        /// </summary>
        public int? LocationId { get; set; }
        public string DeviceModel { get; set; }
        public bool? IsActive { get; set; }
        public long DevId { get; set; }
    }
}
