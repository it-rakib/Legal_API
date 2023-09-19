using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds
{
    public class GetAllCaseFileGridByIdsHandler : IRequestHandler<GetAllCaseFileGridByIdsQuery,GridEntity<GetAllCaseFileGridByIdsVm>>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;

        public GetAllCaseFileGridByIdsHandler(ICasefileMasterRepository casefileMasterRepository)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
        }

        public async Task<GridEntity<GetAllCaseFileGridByIdsVm>> Handle(GetAllCaseFileGridByIdsQuery request, CancellationToken cancellationToken)
        {
            return await _casefileMasterRepository.GetAllCaseFileGridByIds(request.options, request.FileTypeId, request.CourtId, request.StatusId, request.UnitId);
        }
    }
}
