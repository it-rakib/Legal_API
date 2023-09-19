using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Command.CreateUpdateExpense
{
    public class CreateUpdateExpenseValidator : AbstractValidator<CreateUpdateExpenseCommand>
    {
        private readonly IExpenseRepository _expenseRepository;

        public CreateUpdateExpenseValidator(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository ?? throw new ArgumentNullException(nameof(expenseRepository));
            RuleFor(p => p.ExpenseName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(p => p.Amount)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(p => p.ExpenseDate)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueExpenseName)
                .WithMessage("This Expense AllReady Added!");
        }

        private async Task<bool> UniqueExpenseName(CreateUpdateExpenseCommand e, CancellationToken token)
        {
            try
            {
                return !(await _expenseRepository.IsExpenseExist(e.ExpenseId, DateTime.Parse( e.ExpenseDate)));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
