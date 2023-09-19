using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            AttributeAttributeValMappings = new HashSet<AttributeAttributeValMapping>();
            ProductProductAttributeMappings = new HashSet<ProductProductAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AttributeAttributeValMapping> AttributeAttributeValMappings { get; set; }
        public virtual ICollection<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
    }
}
