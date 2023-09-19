using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionGrid
{
    public class GetAllJurisdictionGridHandler : IRequestHandler<GetAllJurisdictionGridQuery,GridEntity<GetAllJurisdictionGridVm>>
    {
        private readonly IJurisdictionRepository _jurisdictionRepository;

        public GetAllJurisdictionGridHandler(IJurisdictionRepository jurisdictionRepository)
        {
            _jurisdictionRepository = jurisdictionRepository ?? throw new ArgumentNullException(nameof(jurisdictionRepository));
        }

        public async Task<GridEntity<GetAllJurisdictionGridVm>> Handle(GetAllJurisdictionGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _jurisdictionRepository.GetAllJurisdictionGrid(request.options);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
