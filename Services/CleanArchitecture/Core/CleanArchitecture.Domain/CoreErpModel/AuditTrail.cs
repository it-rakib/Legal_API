using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class AuditTrail
    {
        public int AuditId { get; set; }
        public DateTime? AuditDate { get; set; }
        public string AuditTask { get; set; }
        public string TaskType { get; set; }
        public string AuditDesc { get; set; }
        public long? AuditedEmpId { get; set; }
        public string EmpIds { get; set; }
        public string PageUrl { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string UserId { get; set; }
        public string Ipaddress { get; set; }
        public string MacAddress { get; set; }
        public string TerminalId { get; set; }
        public DateTime? RowDate { get; set; }
    }
}
