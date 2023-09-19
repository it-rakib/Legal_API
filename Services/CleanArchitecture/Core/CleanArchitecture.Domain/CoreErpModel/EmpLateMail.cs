using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmpLateMail
    {
        public int SendMailId { get; set; }
        public long EmpId { get; set; }
        public int DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public string EmpCode { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? EmailSendDate { get; set; }
        public bool? IsSend { get; set; }
        public bool? IsMailInvaild { get; set; }
        public string ErrorMsg { get; set; }
        public DateTime? MailQueueDate { get; set; }
    }
}
