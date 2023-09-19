using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.Queries
{
    public class GetAllDistrictJurisdictionByCourtHandler : IRequestHandler<GetAllDistrictJurisdictionByCourtQuery,List<GetAllDistrictJurisdictionByCourtVm>>
    {
        private readonly IDistrictWiseJurisdictionRepository _districtWiseJurisdictionRepository;

        public GetAllDistrictJurisdictionByCourtHandler(IDistrictWiseJurisdictionRepository districtWiseJurisdictionRepository)
        {
            _districtWiseJurisdictionRepository = districtWiseJurisdictionRepository ?? throw new ArgumentNullException(nameof(districtWiseJurisdictionRepository));
        }

        public async Task<List<GetAllDistrictJurisdictionByCourtVm>> Handle(GetAllDistrictJurisdictionByCourtQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _districtWiseJurisdictionRepository.GetAllDistrictJurisdictionByCourtId(request.CourtId);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
