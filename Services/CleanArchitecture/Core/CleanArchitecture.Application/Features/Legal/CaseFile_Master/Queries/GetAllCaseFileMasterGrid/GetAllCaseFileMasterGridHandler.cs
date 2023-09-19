using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid
{
    public class GetAllCaseFileMasterGridHandler : IRequestHandler<GetAllCaseFileMasterGridQuery,GridEntity<GetAllCaseFileMasterGridVm>>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;

        public GetAllCaseFileMasterGridHandler(ICasefileMasterRepository casefileMasterRepository)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
        }

        public async Task<GridEntity<GetAllCaseFileMasterGridVm>> Handle(GetAllCaseFileMasterGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _casefileMasterRepository.GetAllCaseFileGrid(request.options);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;

            }   
        }
    }
}
