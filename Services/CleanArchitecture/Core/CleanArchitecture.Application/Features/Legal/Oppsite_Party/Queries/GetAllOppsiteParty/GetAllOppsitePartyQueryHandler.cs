using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Queries.GetAllOppsiteParty
{
    public class GetAllOppsitePartyQueryHandler : IRequestHandler<GetAllOppsitePartyQuery,List<GetAllOppsitePartyVm>>
    {
        private readonly IOppositePartyRepository _oppositePartyRepository;

        public GetAllOppsitePartyQueryHandler(IOppositePartyRepository oppositePartyRepository)
        {
            _oppositePartyRepository = oppositePartyRepository ?? throw new ArgumentNullException(nameof(oppositePartyRepository));
        }
        
        public async Task<List<GetAllOppsitePartyVm>> Handle(GetAllOppsitePartyQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _oppositePartyRepository.GetAllOppsiteParty();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
