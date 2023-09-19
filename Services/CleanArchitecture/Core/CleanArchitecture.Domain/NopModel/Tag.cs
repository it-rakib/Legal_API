using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class Tag
    {
        public Tag()
        {
            ModelTagMappings = new HashSet<ModelTagMapping>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ModelTagMapping> ModelTagMappings { get; set; }
    }
}
