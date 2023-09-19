using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData
{
    public class GetAllCaseTypeGridHandler : IRequestHandler<GetAllCaseTypeGridQuery,GridEntity<GetAllCaseTypeGridVm>>
    {
        private readonly ICaseTypeRepository _caseTypeRepository;

        public GetAllCaseTypeGridHandler(ICaseTypeRepository caseTypeRepository)
        {
            _caseTypeRepository = caseTypeRepository ?? throw new ArgumentNullException(nameof(caseTypeRepository));
        }

        public async Task<GridEntity<GetAllCaseTypeGridVm>> Handle(GetAllCaseTypeGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _caseTypeRepository.GetAllCaseTypeGrid(request.options);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
