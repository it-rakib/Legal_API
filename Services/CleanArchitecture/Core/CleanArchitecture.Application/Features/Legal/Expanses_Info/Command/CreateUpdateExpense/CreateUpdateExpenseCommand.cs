using MediatR;
using System;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Command.CreateUpdateExpense
{
    public class CreateUpdateExpenseCommand : IRequest<CreateUpdateExpenseResponse>
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public decimal? Amount { get; set; }
        public string ExpenseDate { get; set; }
        public int? FileMasterId { get; set; }
        public string Discription { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
    }
}
