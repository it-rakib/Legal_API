using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.UpcomingCases.Queries
{
    public class GetAllUpcomingCasesQuery : IRequest<GridEntity<DashboardCasesVm>>
    {
        public GridOptions options { get; set; }
    }
}
