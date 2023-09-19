using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface ICaseTypeRepository : IAsyncLegalRepository<CaseType>
    {
        Task<CaseType> GetCaseTypeById(int caseTypeId);
        Task<bool> IsCaseTypeExist(int id, string name);
        Task<GridEntity<GetAllCaseTypeGridVm>> GetAllCaseTypeGrid(GridOptions options);
        Task<List<GetAllCaseTypeVm>> GetAllCaseType();

    }
}
