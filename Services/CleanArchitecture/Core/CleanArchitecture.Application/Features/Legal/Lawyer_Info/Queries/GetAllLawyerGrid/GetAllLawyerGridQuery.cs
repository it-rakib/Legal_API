using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyerGrid
{
    public class GetAllLawyerGridQuery : IRequest<GridEntity<GetAllLawyerGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
