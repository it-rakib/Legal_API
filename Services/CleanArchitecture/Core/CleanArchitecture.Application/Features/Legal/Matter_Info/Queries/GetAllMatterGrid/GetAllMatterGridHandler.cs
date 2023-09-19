using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterGrid
{
    public class GetAllMatterGridHandler : IRequestHandler<GetAllMatterGridQuery,GridEntity<GetAllMatterGridVm>>
    {
        private readonly IMatterRepository _matterRepository;

        public GetAllMatterGridHandler(IMatterRepository matterRepository)
        {
            _matterRepository = matterRepository ?? throw new ArgumentNullException(nameof(matterRepository));
        }

        public async Task<GridEntity<GetAllMatterGridVm>> Handle(GetAllMatterGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _matterRepository.GetAllMatterGrid(request.options);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        
        }
    }
}
