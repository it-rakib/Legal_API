using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionGrid
{
    public class GetAllJurisdictionGridQuery : IRequest<GridEntity<GetAllJurisdictionGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
