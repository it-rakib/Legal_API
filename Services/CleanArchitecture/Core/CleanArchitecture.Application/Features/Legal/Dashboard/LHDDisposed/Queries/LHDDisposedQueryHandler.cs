using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LHDDisposed.Queries
{
    public class LHDDisposedQueryHandler : IRequestHandler<LHDDisposedQuery,int>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public LHDDisposedQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public Task<int> Handle(LHDDisposedQuery request, CancellationToken cancellationToken)
        {
            return _dashboardRepository.GetTotalLHDDisposed();
        }
    }
}
