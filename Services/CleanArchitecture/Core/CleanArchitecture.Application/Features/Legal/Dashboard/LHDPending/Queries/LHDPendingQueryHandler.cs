using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LHDPending.Queries
{
    public class LHDPendingQueryHandler : IRequestHandler<LHDPendingQuery,int>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public LHDPendingQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public Task<int> Handle(LHDPendingQuery request, CancellationToken cancellationToken)
        {
            return _dashboardRepository.GetTotalLHDPending();
        }
    }
}
