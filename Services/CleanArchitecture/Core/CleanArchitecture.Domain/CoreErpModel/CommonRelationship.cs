using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class CommonRelationship
    {
        public int RelationshipId { get; set; }
        public string RelationshipName { get; set; }
        public int? GenderId { get; set; }
        public bool? IsActive { get; set; }
    }
}
