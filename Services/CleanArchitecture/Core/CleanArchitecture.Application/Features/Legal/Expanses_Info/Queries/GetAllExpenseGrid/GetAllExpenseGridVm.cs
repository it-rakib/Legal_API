using System;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseGrid
{
    public class GetAllExpenseGridVm
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public int? FileMasterId { get; set; }
        public string RegNo { get; set; }
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CaseNo { get; set; }
        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string Discription { get; set; }
    }
}
