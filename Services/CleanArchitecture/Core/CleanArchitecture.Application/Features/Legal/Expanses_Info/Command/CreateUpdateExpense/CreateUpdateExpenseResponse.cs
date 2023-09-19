using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Command.CreateUpdateExpense
{
    public class CreateUpdateExpenseResponse : BaseResponse
    {
        public CreateUpdateExpenseResponse()
        {
        }
        public CreateUpdateExpenseDto expenseDto { get; set; }
    }
}
