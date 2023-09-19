using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseInfo
{
    public class GetAllExpenseInfoHandler : IRequestHandler<GetAllExpenseInfoQuery,List<GetAllExpenseInfoVm>>
    {
        private readonly IExpenseRepository _expenseRepository;

        public GetAllExpenseInfoHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository ?? throw new ArgumentNullException(nameof(expenseRepository));
        }

        public async Task<List<GetAllExpenseInfoVm>> Handle(GetAllExpenseInfoQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _expenseRepository.GetAllExpenseInfo();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
