using CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitioner;
using CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitionerGrid;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IPetitionerRepository : IAsyncLegalRepository<PetitionerInfo>
    {
        Task<PetitionerInfo> GetPetitionById(int petitionerId);
        Task<bool> IsPetitionNameExist(int id, string name);
        Task<GridEntity<GetAllPetitionerGridVm>> GetAllPetitionerGrid(GridOptions options);
        Task<List<GetAllPetitionerVm>> GetAllPetitioner();
    }
}
