using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetExpenseGridByDate;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class ExpenseReportRepository : LegalBaseRepository<GetExpenseGridByDateVm>, IExpenseReportRepository
    {
        public ExpenseReportRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<GridEntity<GetExpenseGridByDateVm>> GetAllExpenseByDate(GridOptions options, string fromDate, string toDate)
        {
            try
            {
                try
                {
                    var fdate = DateTime.Parse(fromDate);
                    var tDate = DateTime.Parse(toDate);
                    var data = _dbContext.ExpensesInfos.AsNoTracking()
                        .Include(i => i.FileMaster)
                        .Where(f => f.ExpenseDate >= fdate && f.ExpenseDate <= tDate)
                        .Select(s => new GetExpenseGridByDateVm
                        {
                            FileMasterId = s.FileMasterId,
                            RegNo = s.FileMaster.RegNo,
                            FileTypeId = s.FileMaster.FileTypeId,
                            FileTypeName = s.FileMaster.FileType.FileTypeName,
                            IsPublish = s.FileMaster.IsPublish,
                            ExpenseId = s.ExpenseId,
                            ExpenseDate = s.ExpenseDate,
                            ExpenseName = s.ExpenseName,
                            Amount = s.Amount
                        }).OrderBy(o => o.ExpenseDate).AsQueryable();
                    var res = KendoGrid<GetExpenseGridByDateVm>.DataSource(options, data);
                    return await Task.FromResult(res);
                }
                catch (Exception ex)
                {

                    throw ex.InnerException;
                }
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
