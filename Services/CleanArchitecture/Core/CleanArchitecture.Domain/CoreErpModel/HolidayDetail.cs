using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class HolidayDetail
    {
        public int HolidayId { get; set; }
        public DateTime HolidayDate { get; set; }
        public int UnitId { get; set; }
        public int EmpTypeId { get; set; }
        public bool? IsDoublePayment { get; set; }
    }
}
