using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyer;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyerGrid;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface ILawyerInfoRepository : IAsyncLegalRepository<LawyerInfo>
    {
        Task<LawyerInfo> GetLawyerById(int lawyerId);
        Task<bool> IsLawyerNameExist(int id, string name);
        Task<GridEntity<GetAllLawyerGridVm>> GetAllLawyerGrid(GridOptions options);
        Task<List<GetAllLawyerVm>> GetAllLawyer();
    }
}
