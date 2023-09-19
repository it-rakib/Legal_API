using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LADPending.Queries
{
    public class LADPendingQueryHandler : IRequestHandler<LADPendingQuery,int>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public LADPendingQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public Task<int> Handle(LADPendingQuery request, CancellationToken cancellationToken)
        {
            return _dashboardRepository.GetTotalLADPending();
        }
    }
}
