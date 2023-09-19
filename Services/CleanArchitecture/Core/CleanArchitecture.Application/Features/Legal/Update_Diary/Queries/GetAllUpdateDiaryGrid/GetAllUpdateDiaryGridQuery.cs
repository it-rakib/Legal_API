using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiaryGrid
{
    public class GetAllUpdateDiaryGridQuery : IRequest<GridEntity<GetAllUpdateDiaryGridVm>>
    {
        public GridOptions options { get; set; }
        public int FileMasterId { get; set; }
    }
}
