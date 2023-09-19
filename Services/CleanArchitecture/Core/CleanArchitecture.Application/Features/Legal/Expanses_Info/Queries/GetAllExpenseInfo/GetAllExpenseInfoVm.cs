using System;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseInfo
{
    public class GetAllExpenseInfoVm
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public int? FileMasterId { get; set; }
        public string Discription { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
    }
}
