using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitionerGrid
{
    public class GetAllPetitionerGridQuery : IRequest<GridEntity<GetAllPetitionerGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
