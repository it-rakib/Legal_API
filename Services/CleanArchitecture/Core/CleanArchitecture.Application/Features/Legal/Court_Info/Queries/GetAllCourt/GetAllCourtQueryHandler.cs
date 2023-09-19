using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt
{
    public class GetAllCourtQueryHandler : IRequestHandler<GetAllCourtQuery,List<GetAllCourtVm>>
    {
        private readonly ICourtRepository _courtRepository;

        public GetAllCourtQueryHandler(ICourtRepository courtRepository)
        {
            _courtRepository = courtRepository ?? throw new ArgumentNullException(nameof(courtRepository));
        }

        public async Task<List<GetAllCourtVm>> Handle(GetAllCourtQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _courtRepository.GetAllCourt();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
