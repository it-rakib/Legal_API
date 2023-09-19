﻿namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds
{
    public class GetAllCaseFileGridByIdsVm
    {
        public string RegNo { get; set; }
        //public int FileTypeId { get; set; }
        //public string FileTypeName { get; set; }
        //public string OppositeLawyer { get; set; }
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CaseNo { get; set; }
        public string Petitioner { get; set; }
        public string OppositeParty { get; set; }
        public string PetitionerContact { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
