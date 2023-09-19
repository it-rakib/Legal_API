using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class ProductProductAttributeMapping
    {
        public int Id { get; set; }
        public int ProductAttributeId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
