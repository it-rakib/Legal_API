using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Queries.GetAllOppositePartyGrid
{
    public class GetAllOppositePartyGridQuery : IRequest<GridEntity<GetAllOppositePartyGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
