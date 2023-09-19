using CleanArchitecture.Application.Features.Legal.OnBehalfOfInfo.Queries.GetAllOnBehalfOf;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IOnBehalfOfRepository : IAsyncLegalRepository<OnBehalfOf>
    {
        Task<List<GetAllOnBehalfOfVm>> GetAllOnBehalfOf();
    }
}
