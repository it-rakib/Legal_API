using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonEmploymentCategory
    {
        public int EmpCategoryId { get; set; }
        public string EmpCategoryName { get; set; }
        public string EmpCategoryNameBan { get; set; }
        public bool IsActive { get; set; }
    }
}
