using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonTour
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string TourShortName { get; set; }
        public bool IsActive { get; set; }
    }
}
