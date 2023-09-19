using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string DivisionId { get; set; }
        public string RoleId { get; set; }
        public string Status { get; set; }
        public string ZoneId { get; set; }
        public string CircleId { get; set; }
    }
}
