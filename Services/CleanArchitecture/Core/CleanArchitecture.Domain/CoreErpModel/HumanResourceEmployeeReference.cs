using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HumanResourceEmployeeReference
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string RefName { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string Relation { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string TelePhoneNo { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
