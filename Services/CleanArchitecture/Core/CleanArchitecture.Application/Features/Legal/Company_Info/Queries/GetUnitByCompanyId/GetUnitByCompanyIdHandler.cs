using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetUnitByCompanyId
{
    public class GetUnitByCompanyIdHandler : IRequestHandler<GetUnitByCompanyIdQuery,List<GetUnitByCompanyIdVm>>
    {
        private readonly ICompanyRepository _companyRepository;

        public GetUnitByCompanyIdHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
        }

        public async Task<List<GetUnitByCompanyIdVm>> Handle(GetUnitByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _companyRepository.GetUnitByCompanyId(request.CompanyId);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
