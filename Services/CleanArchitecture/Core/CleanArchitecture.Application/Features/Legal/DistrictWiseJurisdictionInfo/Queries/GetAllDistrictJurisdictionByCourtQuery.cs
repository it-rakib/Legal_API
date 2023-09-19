using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.Queries
{
    public class GetAllDistrictJurisdictionByCourtQuery : IRequest<List<GetAllDistrictJurisdictionByCourtVm>>
    {
        public int CourtId { get; set; }
    }
}
