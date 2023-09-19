using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseGrid
{
    public class GetAllExpenseGridHandler : IRequestHandler<GetAllExpenseGridQuery,GridEntity<GetAllExpenseGridVm>>
    {
        private readonly IExpenseRepository _expenseRepository;

        public GetAllExpenseGridHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository ?? throw new ArgumentNullException(nameof(expenseRepository));
        }

        public async Task<GridEntity<GetAllExpenseGridVm>> Handle(GetAllExpenseGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _expenseRepository.GetAllExpenseGrid(request.options);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
