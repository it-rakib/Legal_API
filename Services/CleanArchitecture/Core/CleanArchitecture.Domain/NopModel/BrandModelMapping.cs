using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class BrandModelMapping
    {
        public int BrandModelId { get; set; }
        public int? BrandId { get; set; }
        public int? ModelId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Model Model { get; set; }
    }
}
