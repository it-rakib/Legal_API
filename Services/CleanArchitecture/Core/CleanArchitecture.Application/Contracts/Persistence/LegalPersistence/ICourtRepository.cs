using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourtGrid;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllDistrictByCourtId;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface ICourtRepository : IAsyncLegalRepository<CourtInfo>
    {
        Task<CourtInfo> GetCourtById(int courtId);
        Task<bool> IsCourtNameExist(int id, string name);
        Task<GridEntity<GetAllCourtGridVm>> GetAllCourtGrid(GridOptions options);
        Task<List<GetAllCourtVm>> GetAllCourt();
        Task<CourtInfo> UpdateCourtInfo(CourtInfo courtInfo);
        Task<List<GetAllDistrictByCourtIdVm>> GetAllDistrictByCourtId(int courtId);
    }
}
