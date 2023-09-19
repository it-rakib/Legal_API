using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class IdcardRegistration
    {
        public int IdcardRegNo { get; set; }
        public long? EmpId { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Nid { get; set; }
        public int? BloodGroupId { get; set; }
        public string MobileNo { get; set; }
        public string EmergContactName { get; set; }
        public string EmergContactAddress { get; set; }
        public string EmergContact { get; set; }
        public byte[] EmpPhoto { get; set; }
        public byte[] EmpSignature { get; set; }
        public int? RequestTypeId { get; set; }
        public int? PreviousCardStatusId { get; set; }
        public DateTime? EntryDate { get; set; }
        public long? EntryUserId { get; set; }
        public DateTime? InActiveDate { get; set; }
        public long? InActiveBy { get; set; }
        public int? IsActive { get; set; }
    }
}
