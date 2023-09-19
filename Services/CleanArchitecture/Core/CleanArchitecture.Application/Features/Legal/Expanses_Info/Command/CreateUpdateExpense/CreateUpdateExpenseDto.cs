using System;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Command.CreateUpdateExpense
{
    public class CreateUpdateExpenseDto
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ExpenseDate { get; set; }

    }
}
