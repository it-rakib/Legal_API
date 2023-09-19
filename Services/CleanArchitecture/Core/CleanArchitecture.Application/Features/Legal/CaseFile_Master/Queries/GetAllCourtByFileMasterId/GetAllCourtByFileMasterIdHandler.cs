using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCourtByFileMasterId
{
    public class GetAllCourtByFileMasterIdHandler : IRequestHandler<GetAllCourtByFileMasterIdQuery, List<GetAllCourtByFileMasterIdVm>>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;

        public GetAllCourtByFileMasterIdHandler(ICasefileMasterRepository casefileMasterRepository)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
        }

        public async Task<List<GetAllCourtByFileMasterIdVm>> Handle(GetAllCourtByFileMasterIdQuery request, CancellationToken cancellationToken)
        {
            return await _casefileMasterRepository.GetAllCourtByFileMasterId(request.FileMasterId);
        }
    }
}
