using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileTypeGrid
{
    public class GetAllFileTypeGridQuery : IRequest<GridEntity<GetAllFileTypeGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
