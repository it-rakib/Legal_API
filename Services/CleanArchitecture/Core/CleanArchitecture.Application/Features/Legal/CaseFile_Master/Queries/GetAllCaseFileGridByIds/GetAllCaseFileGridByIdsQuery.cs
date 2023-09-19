using Common.Service.CommonEntities.KendoGrid;
using MediatR;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds
{
    public class GetAllCaseFileGridByIdsQuery : IRequest<GridEntity<GetAllCaseFileGridByIdsVm>>
    {
        public GridOptions options { get; set; }
        public int? FileTypeId { get; set; }
        public int? CourtId { get; set; }
        public int? StatusId { get; set; }
        public int? UnitId { get; set; }
    }
}
