using System;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiary
{
    public class GetAllUpdateDiaryVm
    {
        public int DiaryId { get; set; }
        public int? FileMasterId { get; set; }
        public DateTime? PreviousDate { get; set; }
        public string PreviousDateFor { get; set; }
        public DateTime? NextDate { get; set; }
        public string NextDateFor { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; } 
        public DateTime? StatusDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
