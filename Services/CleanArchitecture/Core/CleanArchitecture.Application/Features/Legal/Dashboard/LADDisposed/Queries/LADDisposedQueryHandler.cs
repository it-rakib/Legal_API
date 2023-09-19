using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LADDisposed.Queries
{
    public class LADDisposedQueryHandler : IRequestHandler<LADDisposedQuery,int>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public LADDisposedQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public Task<int> Handle(LADDisposedQuery request, CancellationToken cancellationToken)
        {
            return _dashboardRepository.GetTotalLADDisposed();
        }
    }
}
