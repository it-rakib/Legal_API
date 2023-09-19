using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LDCPending.Queries
{
    public class LDCPendingQueryHandler : IRequestHandler<LDCPendingQuery,int>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public LDCPendingQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public Task<int> Handle(LDCPendingQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return _dashboardRepository.GetTotalLDCPending();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
