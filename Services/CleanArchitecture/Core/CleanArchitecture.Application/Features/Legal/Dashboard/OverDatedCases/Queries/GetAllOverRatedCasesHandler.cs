using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.OverDatedCases.Queries
{
    public class GetAllOverRatedCasesHandler : IRequestHandler<GetAllOverRatedCasesQuery,GridEntity<DashboardCasesVm>>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public GetAllOverRatedCasesHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public async Task<GridEntity<DashboardCasesVm>> Handle(GetAllOverRatedCasesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _dashboardRepository.GetallOverDatedCase(request.options);
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
