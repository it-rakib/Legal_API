using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.GetCourtByDistrictAndJurisdictionId;
using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.Queries;
using CleanArchitecture.Domain.CoreErpModel;
using CleanArchitecture.Domain.LegalModel;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class DistrictWiseJurisdictionRepository : LegalBaseRepository<DistrictWiseJurisdiction>, IDistrictWiseJurisdictionRepository
    {
        private readonly CoreERPContext _coreERPContext;
        public DistrictWiseJurisdictionRepository(LEGALDBContext dbContext, CoreERPContext coreERPContext) : base(dbContext)
        {
            _coreERPContext = coreERPContext ?? throw new ArgumentNullException(nameof(coreERPContext));

        }

        public async Task<List<GetAllDistrictJurisdictionByCourtVm>> GetAllDistrictJurisdictionByCourtId(int courtId)
        {
            try
            {
                var data = await _dbContext.DistrictWiseJurisdictions.AsNoTracking()
                    .Include(i => i.Jurisdiction)
                    .Where(f => f.CourtId == courtId)
                    .Select(s => new GetAllDistrictJurisdictionByCourtVm
                    {
                        //CourtId = s.CourtId,
                        //DistrictId = s.DistrictId,
                        //DistrictName = GetDistrics((int)s.DistrictId, _coreERPContext),
                        JurisdictionId = s.JurisdictionId,
                        JurisdictionName = s.Jurisdiction.JurisdictionName
                    }).OrderBy(p=> p.JurisdictionName).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
        public static string GetDistrics(int id, CoreERPContext _coreERPContext)
        {
            return _coreERPContext.CommonDistricts.Where(f => f.DistrictId == id).FirstOrDefault().DistrictName;
        }

        public async Task<List<GetCourtByDistrictAndJurisdictionIdVm>> GetCourtByDistrictAndJurisdictionId(int districtId, int jurisdictionId)
        {
            try
            {
                var data = await _dbContext.DistrictWiseJurisdictions.AsNoTracking()
                    .Include(i => i.Court)
                    .Where(f=> f.DistrictId == districtId && f.JurisdictionId == jurisdictionId)
                    .Select(s => new GetCourtByDistrictAndJurisdictionIdVm
                    {
                        CourtId = (int)s.CourtId,
                        CourtName = s.Court.CourtName
                    }).OrderBy(o=> o.CourtName).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
