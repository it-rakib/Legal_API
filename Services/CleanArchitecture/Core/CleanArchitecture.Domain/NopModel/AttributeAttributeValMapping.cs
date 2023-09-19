using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class AttributeAttributeValMapping
    {
        public int AttributeValueMappingId { get; set; }
        public int? PoductAttributeId { get; set; }
        public int ProductAttributeValueId { get; set; }

        public virtual ProductAttribute PoductAttribute { get; set; }
        public virtual ProductAttributeValue ProductAttributeValue { get; set; }
    }
}
