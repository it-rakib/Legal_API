using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.GetCourtByDistrictAndJurisdictionId
{
    public class GetCourtByDistrictAndJurisdictionIdQuery : IRequest<List<GetCourtByDistrictAndJurisdictionIdVm>>
    {
        public int DistrictId { get; set; }
        public int JurisdictionId { get; set; }
    }
}
