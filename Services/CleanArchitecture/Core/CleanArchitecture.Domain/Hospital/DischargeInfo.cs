using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DischargeInfo
    {
        public long Id { get; set; }
        public string RegNo { get; set; }
        public string Diagnosis { get; set; }
        public string ProcedureFindings { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }
        public string Diet { get; set; }
        public string Medicine { get; set; }
        public string Review { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime? DischargeTime { get; set; }
        public string PatientId { get; set; }
        public int? DepartmentId { get; set; }
        public string Hpe { get; set; }
        public DateTime? ProcedureDate { get; set; }
        public DateTime? Nextreporteddate { get; set; }
        public string Advice { get; set; }
        public string Dischargecondition { get; set; }
        public string Consultantlist { get; set; }
        public bool? Pallor { get; set; }
        public bool? Clubbing { get; set; }
        public bool? Cyanosis { get; set; }
        public bool? Edema { get; set; }
        public bool? Icterus { get; set; }
        public bool? Lymphnodes { get; set; }
        public string Temperature { get; set; }
        public string Pulse { get; set; }
        public string Bp { get; set; }
        public string Centralnervoussystem { get; set; }
        public string Respiratorysystem { get; set; }
        public string Cardiovascularsystem { get; set; }
        public string Coursehospital { get; set; }
    }
}
