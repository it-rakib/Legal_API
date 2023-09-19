using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionByCourtId
{
    public class GetAllJurisdictionByCourtIdQuery : IRequest<List<GetAllJurisdictionByCourtIdVm>>
    {
        public int CourtId { get; set; }
    }
}
