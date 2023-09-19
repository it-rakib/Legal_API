using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LDCDisposed.Queries
{
    public class LDCDisposedQueryHandler : IRequestHandler<LDCDisposedQuery,int>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public LDCDisposedQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public Task<int> Handle(LDCDisposedQuery request, CancellationToken cancellationToken)
        {
            return _dashboardRepository.GetTotalLDCDisposed();
        }
    }
}
