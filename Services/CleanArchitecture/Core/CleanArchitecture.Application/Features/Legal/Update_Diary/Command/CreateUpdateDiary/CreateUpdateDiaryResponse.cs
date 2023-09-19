using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Command.CreateUpdateDiary
{
    public class CreateUpdateDiaryResponse : BaseResponse
    {
        public CreateUpdateDiaryResponse()
        {
        }
        public CreateUpdateDiaryDto diaryDto { get; set; }
    }
}
