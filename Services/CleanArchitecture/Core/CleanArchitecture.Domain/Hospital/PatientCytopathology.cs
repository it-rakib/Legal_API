using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientCytopathology
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string Volume { get; set; }
        public string Colour { get; set; }
        public string Appearance { get; set; }
        public string RedBloodCell { get; set; }
        public string WhiteBloodCell { get; set; }
        public string Neutrophil { get; set; }
        public string Lymphocyte { get; set; }
        public string Monocyte { get; set; }
        public string AtypicalCell { get; set; }
    }
}
