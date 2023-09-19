using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid
{
    public class GetAllCaseFileMasterGridQuery : IRequest<GridEntity<GetAllCaseFileMasterGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
