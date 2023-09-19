using System;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetExpenseGridByDate
{
    public class GetExpenseGridByDateVm
    {
        public int? FileMasterId { get; set; }
        public string RegNo { get; set; }
        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public bool? IsPublish { get; set; }
        public int ExpenseId { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public string ExpenseName { get; set; }
        public decimal? Amount { get; set; }
    }
}
