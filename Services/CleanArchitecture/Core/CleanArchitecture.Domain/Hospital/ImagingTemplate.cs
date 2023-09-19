using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ImagingTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public int? LabModuleId { get; set; }
    }
}
