using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Dashboard.LLCPending.Queries
{
    public class LLCPendingHandler : IRequestHandler<LLCPendingQuery,int>
    {
        private readonly IDashboardRepository _repository;

        public LLCPendingHandler(IDashboardRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Task<int> Handle(LLCPendingQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return _repository.GetTotalLLCPending();

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
