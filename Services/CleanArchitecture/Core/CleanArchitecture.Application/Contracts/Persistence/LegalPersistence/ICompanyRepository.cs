using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetAllCompany;
using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetUnitByCompanyId;
using CleanArchitecture.Domain.CoreErpModel;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface ICompanyRepository : IAsyncLegalRepository<CommonCompany>
    {
        Task<List<GetAllCompanyVm>> GetAllCompany();
        Task<List<GetUnitByCompanyIdVm>> GetUnitByCompanyId(int companyId);
    }
}
