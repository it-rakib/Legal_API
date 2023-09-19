using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetExpenseGridByDate;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IExpenseReportRepository : IAsyncLegalRepository<GetExpenseGridByDateVm>
    {
        Task<GridEntity<GetExpenseGridByDateVm>> GetAllExpenseByDate(GridOptions options, string fromDate, string toDate);
    }
}
