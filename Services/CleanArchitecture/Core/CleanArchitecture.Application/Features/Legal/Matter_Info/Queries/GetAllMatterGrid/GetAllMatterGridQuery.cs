using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterGrid
{
    public class GetAllMatterGridQuery : IRequest<GridEntity<GetAllMatterGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
