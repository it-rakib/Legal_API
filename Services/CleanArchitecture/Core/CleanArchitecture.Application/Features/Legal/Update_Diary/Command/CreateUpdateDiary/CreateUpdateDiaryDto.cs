using System;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Command.CreateUpdateDiary
{
    public class CreateUpdateDiaryDto
    {
        public int DiaryId { get; set; }
        public int? FileMasterId { get; set; }
        public DateTime? PreviousDate { get; set; }
        public string PreviousDateFor { get; set; }
        public DateTime? NextDate { get; set; }
        public string NextDateFor { get; set; }
    }
}
