using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiary
{
    public class GetAllUpdateDiaryQuery : IRequest<List<GetAllUpdateDiaryVm>>
    {
    }
}
