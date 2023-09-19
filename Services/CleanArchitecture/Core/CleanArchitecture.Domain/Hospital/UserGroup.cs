using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class UserGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
    }
}
