using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenRecipeDetail
    {
        public long Id { get; set; }
        public long? RecipeId { get; set; }
        public int? MatiralId { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public int? UserId { get; set; }
        public decimal? CostRate { get; set; }
    }
}
