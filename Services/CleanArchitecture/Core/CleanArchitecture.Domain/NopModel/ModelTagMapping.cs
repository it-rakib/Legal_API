using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class ModelTagMapping
    {
        public int ModelTagMapId { get; set; }
        public int? ModelId { get; set; }
        public int? TagId { get; set; }

        public virtual Model Model { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
