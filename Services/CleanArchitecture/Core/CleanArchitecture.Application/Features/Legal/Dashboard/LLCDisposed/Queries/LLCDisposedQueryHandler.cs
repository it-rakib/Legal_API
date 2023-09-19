using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LLCDisposed.Queries
{
    public class LLCDisposedQueryHandler : IRequestHandler<LLCDisposedQuery,int>
    {
        private readonly IDashboardRepository _dashboardRepository;

        public LLCDisposedQueryHandler(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
        }

        public Task<int> Handle(LLCDisposedQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return _dashboardRepository.GetTotalLLCDisposed();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
