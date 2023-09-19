using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Command.CreateUpdateExpense
{
    public class CreateUpdateExpenseHandler : IRequestHandler<CreateUpdateExpenseCommand,CreateUpdateExpenseResponse>
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly ILogger<CreateUpdateExpenseHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateExpenseHandler(IExpenseRepository expenseRepository, ILogger<CreateUpdateExpenseHandler> logger, IMapper mapper)
        {
            _expenseRepository = expenseRepository ?? throw new ArgumentNullException(nameof(expenseRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateExpenseResponse> Handle(CreateUpdateExpenseCommand request, CancellationToken cancellationToken)
        {
            var expenseResponse = new CreateUpdateExpenseResponse();
            try
            {
                var validator = new CreateUpdateExpenseValidator(_expenseRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    expenseResponse.Success = false;
                    expenseResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        expenseResponse.Message = expenseResponse.Message + Environment.NewLine + error.ErrorMessage;
                        expenseResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(expenseResponse.Message);
                }

                if (expenseResponse.Success)
                {
                    var expenseInfo = new ExpensesInfo
                    {
                        ExpenseId = request.ExpenseId,
                        ExpenseName = request.ExpenseName,
                        Amount = request.Amount,
                        ExpenseDate = DateTime.Parse( request.ExpenseDate),
                        FileMasterId = request.FileMasterId,
                        Discription = request.Discription,
                        CreatedAt = DateTime.Now,
                        CreatedBy = request.CreatedBy
                    };
                    if (request.ExpenseId == 0)
                    {
                        expenseInfo = await _expenseRepository.AddAsync(expenseInfo);
                        expenseResponse.Message = expenseInfo.ExpenseName + " Saved Successfully!";
                    }
                    else
                    {
                        var expenseInfoId = await _expenseRepository.GetCaseExpenseById(request.ExpenseId);
                        if (expenseInfoId != null)
                        {
                            await _expenseRepository.Update(expenseInfo);
                            expenseResponse.Message = expenseInfo.ExpenseName + " Updated Successfully!";
                        }
                        else
                        {
                            expenseResponse.Message = "Data Not Found!";
                        }
                    }
                    expenseResponse.expenseDto = _mapper.Map<CreateUpdateExpenseDto>(expenseInfo);

                }
                _logger.LogInformation(expenseResponse.Message);
                return expenseResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
