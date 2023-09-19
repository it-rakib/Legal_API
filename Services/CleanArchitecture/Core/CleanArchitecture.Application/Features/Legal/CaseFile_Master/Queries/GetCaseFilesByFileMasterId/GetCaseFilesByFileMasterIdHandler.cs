using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetCaseFilesByFileMasterId
{
    public class GetCaseFilesByFileMasterIdHandler : IRequestHandler<GetCaseFilesByFileMasterIdQuery,List<GetCaseFilesByFileMasterIdVm>>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;

        public GetCaseFilesByFileMasterIdHandler(ICasefileMasterRepository casefileMasterRepository)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
        }

        public async Task<List<GetCaseFilesByFileMasterIdVm>> Handle(GetCaseFilesByFileMasterIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _casefileMasterRepository.GetCaseFilesByFileMasterId(request.FileMasterId);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
