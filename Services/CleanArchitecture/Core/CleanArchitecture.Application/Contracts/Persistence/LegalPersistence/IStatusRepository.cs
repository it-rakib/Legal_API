using CleanArchitecture.Application.Features.Legal.Status_Info.Queries.GetAllStatus;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IStatusRepository : IAsyncLegalRepository<StatusInfo>
    {
        Task<List<GetAllStatusVm>> GetAllStatus();
    }
}
