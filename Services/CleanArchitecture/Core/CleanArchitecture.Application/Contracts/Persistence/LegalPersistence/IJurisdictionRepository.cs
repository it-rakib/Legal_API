using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdiction;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionByCourtId;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionGrid;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IJurisdictionRepository : IAsyncLegalRepository<JurisdictionInfo>
    {
        Task<JurisdictionInfo> GetJurisdictionById(int jurisdictionId);
        Task<bool> IsJurisdictionNameExist(int id, string name);
        Task<GridEntity<GetAllJurisdictionGridVm>> GetAllJurisdictionGrid(GridOptions options);
        Task<List<GetAllJurisdictionVm>> GetAllJurisdiction();
        Task<List<GetAllJurisdictionByCourtIdVm>> GetAllJurisdictionByCourtId(int courtId);

    }
}
