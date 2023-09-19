using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseGrid
{
    public class GetAllExpenseGridQuery : IRequest<GridEntity<GetAllExpenseGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
