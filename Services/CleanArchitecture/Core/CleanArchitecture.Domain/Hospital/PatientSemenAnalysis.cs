using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientSemenAnalysis
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string MethodOfCollection { get; set; }
        public string TimeOfCollection { get; set; }
        public string TimeOfExamination { get; set; }
        public string Volume { get; set; }
        public string Colour { get; set; }
        public string Odour { get; set; }
        public string Viscosity { get; set; }
        public string Reaction { get; set; }
        public string SpermCount { get; set; }
        public string MorphologyNormal { get; set; }
        public string MorphologyAbnormal { get; set; }
        public string ActivelyMotile { get; set; }
        public string ReducedMotile { get; set; }
        public string NonMotile { get; set; }
        public string ClumpingSperm { get; set; }
        public string Rbc { get; set; }
        public string PusCells { get; set; }
        public string EpithelialCells { get; set; }
        public string Comments { get; set; }
    }
}
