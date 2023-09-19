using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class Model
    {
        public Model()
        {
            BrandModelMappings = new HashSet<BrandModelMapping>();
            ModelTagMappings = new HashSet<ModelTagMapping>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BrandModelMapping> BrandModelMappings { get; set; }
        public virtual ICollection<ModelTagMapping> ModelTagMappings { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
