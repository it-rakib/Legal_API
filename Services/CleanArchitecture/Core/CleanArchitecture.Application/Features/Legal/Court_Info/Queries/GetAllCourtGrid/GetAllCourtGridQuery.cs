using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourtGrid
{
    public class GetAllCourtGridQuery : IRequest<GridEntity<GetAllCourtGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
