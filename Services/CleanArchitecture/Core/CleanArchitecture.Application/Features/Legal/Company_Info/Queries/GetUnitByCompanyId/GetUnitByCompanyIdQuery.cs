using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetUnitByCompanyId
{
    public class GetUnitByCompanyIdQuery : IRequest<List<GetUnitByCompanyIdVm>>
    {
        public int CompanyId { get; set; }
    }
}
