using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMaster
{
    public class GetAllFileMasterQueryHandler : IRequestHandler<GetAllFileMasterQuery,List<GetAllFileMasterVm>>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;

        public GetAllFileMasterQueryHandler(ICasefileMasterRepository casefileMasterRepository)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
        }

        public async Task<List<GetAllFileMasterVm>> Handle(GetAllFileMasterQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _casefileMasterRepository.GetAllCaseFile();
                
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
