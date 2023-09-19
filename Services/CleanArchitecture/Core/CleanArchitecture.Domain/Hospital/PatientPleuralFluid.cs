using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientPleuralFluid
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string Quantity { get; set; }
        public string Volume { get; set; }
        public string Color { get; set; }
        public string Deposit { get; set; }
        public string TotalProtein { get; set; }
        public string Glucose { get; set; }
        public string Ada { get; set; }
        public string Ldh { get; set; }
        public string LeucocytesCount { get; set; }
        public string DifferentialCount { get; set; }
        public string Neutrophils { get; set; }
        public string Lymphocytes { get; set; }
        public string Eosinophils { get; set; }
        public string Monocytes { get; set; }
        public string Basophils { get; set; }
        public string DegeneratedCells { get; set; }
        public string OthersEpithelialCells { get; set; }
        public string RedBloodCells { get; set; }
        public string GramStain { get; set; }
        public string Afzstain { get; set; }
    }
}
