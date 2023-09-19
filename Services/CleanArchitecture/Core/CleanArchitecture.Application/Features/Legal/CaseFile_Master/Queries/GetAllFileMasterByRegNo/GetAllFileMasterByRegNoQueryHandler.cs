using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo
{
    public class GetAllFileMasterByRegNoQueryHandler : IRequestHandler<GetAllFileMasterByRegNoQuery,List<GetAllFileMasterByRegNoVm>>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;

        public GetAllFileMasterByRegNoQueryHandler(ICasefileMasterRepository casefileMasterRepository)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
        }

        public async Task<List<GetAllFileMasterByRegNoVm>> Handle(GetAllFileMasterByRegNoQuery request, CancellationToken cancellationToken)
        {
            return await _casefileMasterRepository.GetAllCaseFileByRegNo(request.Search);
        }
    }
}
