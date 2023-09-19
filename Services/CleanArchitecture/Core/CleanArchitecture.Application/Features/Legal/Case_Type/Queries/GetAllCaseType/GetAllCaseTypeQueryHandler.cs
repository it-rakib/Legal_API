using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType
{
    public class GetAllCaseTypeQueryHandler : IRequestHandler<GetAllCaseTypeQuery,List<GetAllCaseTypeVm>>
    {
        private readonly ICaseTypeRepository _caseTypeRepository;

        public GetAllCaseTypeQueryHandler(ICaseTypeRepository caseTypeRepository)
        {
            _caseTypeRepository = caseTypeRepository ?? throw new ArgumentNullException(nameof(caseTypeRepository));
        }

        public async Task<List<GetAllCaseTypeVm>> Handle(GetAllCaseTypeQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _caseTypeRepository.GetAllCaseType();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
