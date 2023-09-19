using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllDistrictByCourtId
{
    public class GetAllDistrictByCourtIdQuery : IRequest<List<GetAllDistrictByCourtIdVm>>
    {
        public int CourtId { get; set; }
    }
}
