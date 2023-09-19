using CleanArchitecture.Application.Features.Legal.Oppsite_Party.Queries.GetAllOppositePartyGrid;
using CleanArchitecture.Application.Features.Legal.Oppsite_Party.Queries.GetAllOppsiteParty;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IOppositePartyRepository : IAsyncLegalRepository<OppositeParty>
    {
        Task<OppositeParty> GetOppositePrtyById(int partyId);
        Task<bool> IsPartyUnique(int partyId,string partyName);
        Task<GridEntity<GetAllOppositePartyGridVm>> GetAllOppositePartyGrid(GridOptions options);
        Task<List<GetAllOppsitePartyVm>> GetAllOppsiteParty();
    }
}
