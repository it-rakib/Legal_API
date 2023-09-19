using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class ComboValue
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
