using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonGender
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public string GenderNameBan { get; set; }
        public bool? IsActive { get; set; }
    }
}
