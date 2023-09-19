using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.OverDatedCases.Queries
{
    public class GetAllOverRatedCasesQuery : IRequest<GridEntity<DashboardCasesVm>>
    {
       public GridOptions options { get;set; }
    }
}
