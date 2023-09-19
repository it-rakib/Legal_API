using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class PatientHaemotologyDetail
    {
        public long Id { get; set; }
        public long MemoId { get; set; }
        public string WhiteBloodCells { get; set; }
        public string Rbc { get; set; }
        public string Haemoglobin { get; set; }
        public string HctPcv { get; set; }
        public string Platelets { get; set; }
        public string Lymphocytes { get; set; }
        public string Monocytes { get; set; }
        public string Mcv { get; set; }
        public string Mch { get; set; }
        public string Mchc { get; set; }
        public string Rdw { get; set; }
        public string Mpv { get; set; }
        public string Pct { get; set; }
        public string Pdw { get; set; }
        public string Esr { get; set; }
        public string Neutrophils { get; set; }
        public string Eosinophils { get; set; }
        public string Basophils { get; set; }
        public string Chcm { get; set; }
        public string Ch { get; set; }
        public string Hdw { get; set; }
        public string Luc { get; set; }
        public string Nrbc { get; set; }
        public string NeutrophilsAb { get; set; }
        public string LymphocytesAb { get; set; }
        public string MonocytesAb { get; set; }
        public string EosinophilsAb { get; set; }
        public string BasophilsAb { get; set; }
        public string Lucab { get; set; }
        public string Nrbcab { get; set; }
        public string Reticulocytes { get; set; }
        public string MalarialParasites { get; set; }
        public string CirculatingEosinophils { get; set; }
        public string BleedingTime { get; set; }
        public string ClottingTime { get; set; }
        public string IctForMalaria { get; set; }
        public string Rbcs { get; set; }
        public string Wbcs { get; set; }
        public string Plts { get; set; }
        public string Comments { get; set; }
        public string Advice1 { get; set; }
        public string Advice2 { get; set; }
    }
}
