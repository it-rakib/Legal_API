using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData
{
    public class GetAllCaseTypeGridQuery : IRequest<GridEntity<GetAllCaseTypeGridVm>>
    {
        public GridOptions options { get; set; }
    }
}
