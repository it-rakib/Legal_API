using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.UpcomingCases.Queries
{
    public class GetAllUpcomingCasesHandler : IRequestHandler<GetAllUpcomingCasesQuery,GridEntity<DashboardCasesVm>>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public GetAllUpcomingCasesHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public async Task<GridEntity<DashboardCasesVm>> Handle(GetAllUpcomingCasesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _dashboardRepository.GetallUpcomingCase(request.options);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
