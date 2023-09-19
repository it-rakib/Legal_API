using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class EmailSend
    {
        public int SendId { get; set; }
        public long? ApproverEmpId { get; set; }
        public long? ApplicantEmpId { get; set; }
        public int? ApplicationId { get; set; }
        public int? ActionStatus { get; set; }
        public int? CategoryId { get; set; }
        public string Tag { get; set; }
        public DateTime? EmailSendDate { get; set; }
        public bool? IsSend { get; set; }
        public bool? IsEmailInvalid { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? MailQueueDate { get; set; }
    }
}
