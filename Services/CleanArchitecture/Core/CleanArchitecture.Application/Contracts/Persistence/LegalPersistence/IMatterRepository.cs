using CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterGrid;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterInfo;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IMatterRepository : IAsyncLegalRepository<MatterInfo>
    {
        Task<MatterInfo> GetMatterById(int matterId);
        Task<bool> IsMatterExist(int id, string name);
        Task<GridEntity<GetAllMatterGridVm>> GetAllMatterGrid(GridOptions options);
        Task<List<GetAllMatterVm>> GetAllMAtter();
    }
}
