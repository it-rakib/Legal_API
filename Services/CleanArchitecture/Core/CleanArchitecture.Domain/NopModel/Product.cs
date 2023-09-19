using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class Product
    {
        public Product()
        {
            ProductProductAttributeMappings = new HashSet<ProductProductAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public int? ModelId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
    }
}
