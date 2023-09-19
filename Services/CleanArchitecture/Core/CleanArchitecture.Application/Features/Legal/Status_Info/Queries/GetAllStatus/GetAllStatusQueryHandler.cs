using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Status_Info.Queries.GetAllStatus
{
    public class GetAllStatusQueryHandler : IRequestHandler<GetAllStatusQuery,List<GetAllStatusVm>>
    {
        private readonly IStatusRepository _statusRepository;

        public GetAllStatusQueryHandler(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository ?? throw new ArgumentNullException(nameof(statusRepository));
        }

        public async Task<List<GetAllStatusVm>> Handle(GetAllStatusQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _statusRepository.GetAllStatus();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
