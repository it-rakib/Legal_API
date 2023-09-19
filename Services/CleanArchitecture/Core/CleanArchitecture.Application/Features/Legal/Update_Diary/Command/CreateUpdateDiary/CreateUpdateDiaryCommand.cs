using MediatR;
using System;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Command.CreateUpdateDiary
{
    public class CreateUpdateDiaryCommand : IRequest<CreateUpdateDiaryResponse>
    {
        public int DiaryId { get; set; }
        public int? FileMasterId { get; set; }
        public string PreviousDate { get; set; }
        public string PreviousDateFor { get; set; }
        public string NextDate { get; set; }
        public string NextDateFor { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public string StatusDate { get; set; }
    }
}
