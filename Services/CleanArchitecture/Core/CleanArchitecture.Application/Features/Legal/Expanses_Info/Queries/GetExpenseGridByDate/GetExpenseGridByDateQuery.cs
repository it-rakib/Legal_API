using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetExpenseGridByDate
{
    public class GetExpenseGridByDateQuery : IRequest<GridEntity<GetExpenseGridByDateVm>>
    {
        public GridOptions options { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
    }
}
