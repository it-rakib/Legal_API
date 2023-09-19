using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Queries.GetAllOppositePartyGrid
{
    public class GetAllOppositePartyGridHandler : IRequestHandler<GetAllOppositePartyGridQuery,GridEntity<GetAllOppositePartyGridVm>>
    {
        private readonly IOppositePartyRepository _oppositePartyRepository;

        public GetAllOppositePartyGridHandler(IOppositePartyRepository oppositePartyRepository)
        {
            _oppositePartyRepository = oppositePartyRepository ?? throw new ArgumentNullException(nameof(oppositePartyRepository));
        }

        public async Task<GridEntity<GetAllOppositePartyGridVm>> Handle(GetAllOppositePartyGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _oppositePartyRepository.GetAllOppositePartyGrid(request.options);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
