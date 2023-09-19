using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetExpenseGridByDate
{
    public class GetExpenseGridByDateHandler : IRequestHandler<GetExpenseGridByDateQuery,GridEntity<GetExpenseGridByDateVm>>
    {
        private readonly IExpenseReportRepository _expenseReport;

        public GetExpenseGridByDateHandler(IExpenseReportRepository expenseReport)
        {
            _expenseReport = expenseReport ?? throw new ArgumentNullException(nameof(expenseReport));
        }

        public async Task<GridEntity<GetExpenseGridByDateVm>> Handle(GetExpenseGridByDateQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _expenseReport.GetAllExpenseByDate(request.options, request.fromDate, request.toDate);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
