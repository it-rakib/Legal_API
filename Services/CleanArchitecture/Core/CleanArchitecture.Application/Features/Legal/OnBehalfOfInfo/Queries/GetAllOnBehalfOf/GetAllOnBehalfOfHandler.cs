using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.OnBehalfOfInfo.Queries.GetAllOnBehalfOf
{
    public class GetAllOnBehalfOfHandler : IRequestHandler<GetAllOnBehalfOfQuery,List<GetAllOnBehalfOfVm>>
    {
        private readonly IOnBehalfOfRepository _onBehalfOfRepository;

        public GetAllOnBehalfOfHandler(IOnBehalfOfRepository onBehalfOfRepository)
        {
            _onBehalfOfRepository = onBehalfOfRepository ?? throw new ArgumentNullException(nameof(onBehalfOfRepository));
        }

        public async Task<List<GetAllOnBehalfOfVm>> Handle(GetAllOnBehalfOfQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _onBehalfOfRepository.GetAllOnBehalfOf();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
