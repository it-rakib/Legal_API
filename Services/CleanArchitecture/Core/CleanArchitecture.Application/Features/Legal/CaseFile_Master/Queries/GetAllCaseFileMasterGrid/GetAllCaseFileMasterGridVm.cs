using CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid
{
    public class GetAllCaseFileMasterGridVm
    {
        public int FileMasterId { get; set; }
        public string RegNo { get; set; }
        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }       
        public string OppositeLawyer { get; set; }
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CaseNo { get; set; }
        public string FillingLawyer { get; set; }
        public int AssignLawyer { get; set; }
        public string AssignLawyerName { get; set; }
        public string Discription { get; set; }
        public bool? IsPublish { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int MatterId { get; set; }
        public string MatterName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public int? UpdatedBy { get; set; }
        public string Petitioner { get; set; }
        public string OppositeParty { get; set; }
        public string PetitionerContact { get; set; }
        public string OppositePartyContact { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime? StatusDate { get; set; }
        public string FillingLawyerContact { get; set; }
        public string OppositeLawyerContact { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int? OnBehalfOfId { get; set; }
        public string OnBehalfOfName { get; set; }
        //public int JurisdictionName { get; set; }
        public virtual List<FilesVm> FilesVm { get; set; }
    }
}
