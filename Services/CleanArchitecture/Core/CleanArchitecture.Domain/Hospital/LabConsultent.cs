using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class LabConsultent
    {
        public LabConsultent()
        {
            LabConsultTrans = new HashSet<LabConsultTran>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Others { get; set; }
        public string Institution { get; set; }
        public int? Module { get; set; }
        public int? Consultent2 { get; set; }
        public byte[] Signature { get; set; }
        public bool? IsActive { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public int? DepartmentId { get; set; }

        public virtual ICollection<LabConsultTran> LabConsultTrans { get; set; }
    }
}
