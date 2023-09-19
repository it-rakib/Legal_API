using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetAllCompany
{
    public class GetAllCompanyHandler : IRequestHandler<GetAllCompanyQuery,List<GetAllCompanyVm>>
    {
        private readonly ICompanyRepository _companyRepository;

        public GetAllCompanyHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
        }

        public async Task<List<GetAllCompanyVm>> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _companyRepository.GetAllCompany();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
