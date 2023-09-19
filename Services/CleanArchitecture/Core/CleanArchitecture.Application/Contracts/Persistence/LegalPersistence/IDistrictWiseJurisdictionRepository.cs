using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.GetCourtByDistrictAndJurisdictionId;
using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.Queries;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IDistrictWiseJurisdictionRepository : IAsyncLegalRepository<DistrictWiseJurisdiction>
    {
        Task<List<GetAllDistrictJurisdictionByCourtVm>> GetAllDistrictJurisdictionByCourtId(int courtId);
        Task<List<GetCourtByDistrictAndJurisdictionIdVm>> GetCourtByDistrictAndJurisdictionId(int districtId, int jurisdictionId);
    }
}
