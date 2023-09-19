using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseGrid;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseInfo;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IExpenseRepository : IAsyncLegalRepository<ExpensesInfo>
    {
        Task<ExpensesInfo> GetCaseExpenseById(int expenseId);
        Task<bool> IsExpenseExist(int id, DateTime expenseDate);
        Task<List<GetAllExpenseInfoVm>> GetAllExpenseInfo();
        Task<GridEntity<GetAllExpenseGridVm>> GetAllExpenseGrid(GridOptions options);
    }
}
