namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo
{
    public class GetAllFileMasterByRegNoVm
    {
        public int FileMasterId { get; set; }
        public string RegNo { get; set; }
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CaseNo { get; set; }
    }
}
