using System;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiaryGrid
{
    public class GetAllUpdateDiaryGridVm
    {
        public int DiaryId { get; set; }
        public int? FileMasterId { get; set; }
        public string RegNo { get; set; }
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CaseNo { get; set; }
        public DateTime? PreviousDate { get; set; }
        public string PreviousDateFor { get; set; }
        public DateTime? NextDate { get; set; }
        public string NextDateFor { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get;set; }
        public DateTime? StatusDate { get; set; }
    }
}
