using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourtGrid
{
    public class GetAllCourtGridHandler : IRequestHandler<GetAllCourtGridQuery, GridEntity<GetAllCourtGridVm>>
    {
        private readonly ICourtRepository _courtRepository;

        public GetAllCourtGridHandler(ICourtRepository courtRepository)
        {
            _courtRepository = courtRepository ?? throw new ArgumentNullException(nameof(courtRepository));
        }

        public async Task<GridEntity<GetAllCourtGridVm>> Handle(GetAllCourtGridQuery request, CancellationToken cancellationToken)
        {
            var res = await _courtRepository.GetAllCourtGrid(request.options);
            return res;
        }
    }
}
