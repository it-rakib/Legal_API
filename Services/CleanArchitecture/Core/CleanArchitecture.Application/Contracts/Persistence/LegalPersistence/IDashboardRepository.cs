using CleanArchitecture.Application.Features.Legal.Dashboard;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IDashboardRepository : IAsyncLegalRepository<DashboardCasesVm>
    {
        Task<GridEntity<DashboardCasesVm>> GetallUpcomingCase(GridOptions options);
        Task<GridEntity<DashboardCasesVm>> GetallOverDatedCase(GridOptions options);
        Task<int> GetTotalLLCPending();
        Task<int> GetTotalLLCDisposed();
        Task<int> GetTotalLDCPending();
        Task<int> GetTotalLDCDisposed();
        Task<int> GetTotalLHDPending();
        Task<int> GetTotalLHDDisposed();
        Task<int> GetTotalLADPending();
        Task<int> GetTotalLADDisposed();
    }
}
