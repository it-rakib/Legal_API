using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseGrid;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseInfo;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class ExpenseRepository : LegalBaseRepository<ExpensesInfo>, IExpenseRepository
    {
        public ExpenseRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<GridEntity<GetAllExpenseGridVm>> GetAllExpenseGrid(GridOptions options)
        {
            try
            {
                var data = _dbContext.ExpensesInfos.AsNoTracking()
                    .Include(i => i.FileMaster)
                    .Select(s => new GetAllExpenseGridVm
                    {
                        ExpenseId = s.ExpenseId,
                        ExpenseName = s.ExpenseName,
                        Amount = s.Amount,
                        ExpenseDate = s.ExpenseDate,
                        FileMasterId = s.FileMasterId,
                        RegNo = s.FileMaster.RegNo,
                        CourtId = s.FileMaster.CourtId,
                        CourtName = s.FileMaster.Court.CourtName,
                        CaseNo = s.FileMaster.CaseNo,
                        FileTypeName = s.FileMaster.FileType.FileTypeName,
                        Discription = s.Discription
                    }).OrderBy(o=> o.ExpenseDate).AsQueryable();
                var res = KendoGrid<GetAllExpenseGridVm>.DataSource(options, data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<List<GetAllExpenseInfoVm>> GetAllExpenseInfo()
        {
            var result = await _dbContext.ExpensesInfos.AsNoTracking()
                .Select(s => new GetAllExpenseInfoVm
                {
                    ExpenseId = s.ExpenseId,
                    ExpenseName = s.ExpenseName,
                    Amount = s.Amount,
                    ExpenseDate = s.ExpenseDate,
                    FileMasterId = s.FileMasterId,
                    Discription = s.Discription,
                    CreatedBy = s.CreatedBy
                }).ToListAsync();
            return result;
        }

        public async Task<ExpensesInfo> GetCaseExpenseById(int expenseId)
        {
            try
            {
                return await _dbContext.ExpensesInfos.AsNoTracking().Where(f => f.ExpenseId == expenseId).FirstOrDefaultAsync();

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        
        }

        public async Task<bool> IsExpenseExist(int id, DateTime expenseDate)
        {
            try
            {
                var existsdata = (await _dbContext.ExpensesInfos.AsNoTracking()
                .Where(a => id == 0 ? a.ExpenseDate == expenseDate : a.ExpenseDate == expenseDate && a.ExpenseId != id)
                                .OrderBy(o => o.ExpenseName).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
