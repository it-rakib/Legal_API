using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.GetCourtByDistrictAndJurisdictionId
{
    public class GetCourtByDistrictAndJurisdictionIdHandler : IRequestHandler<GetCourtByDistrictAndJurisdictionIdQuery,List<GetCourtByDistrictAndJurisdictionIdVm>>
    {
        private readonly IDistrictWiseJurisdictionRepository _districtWiseJurisdictionRepository;

        public GetCourtByDistrictAndJurisdictionIdHandler(IDistrictWiseJurisdictionRepository districtWiseJurisdictionRepository)
        {
            _districtWiseJurisdictionRepository = districtWiseJurisdictionRepository ?? throw new ArgumentNullException(nameof(districtWiseJurisdictionRepository));
        }

        public async Task<List<GetCourtByDistrictAndJurisdictionIdVm>> Handle(GetCourtByDistrictAndJurisdictionIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _districtWiseJurisdictionRepository.GetCourtByDistrictAndJurisdictionId(request.DistrictId, request.JurisdictionId);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
