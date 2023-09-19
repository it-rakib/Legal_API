using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HolidayAllocateReligionWise
    {
        public int HolidayId { get; set; }
        public int ReligionId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public bool IsBonusApplicable { get; set; }
        public DateTime? BonusEffectDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryUserId { get; set; }
    }
}
