using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourtGrid;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllDistrictByCourtId;
using CleanArchitecture.Domain.CoreErpModel;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class CourtRepository : LegalBaseRepository<CourtInfo>, ICourtRepository
    {
        private readonly CoreERPContext _coreERPContext;
        public CourtRepository(LEGALDBContext dbContext, CoreERPContext coreERPContext) : base(dbContext)
        {
            _coreERPContext = coreERPContext ?? throw new ArgumentNullException(nameof(coreERPContext));
        }

        public async Task<List<GetAllCourtVm>> GetAllCourt()
        {
            var data = await _dbContext.CourtInfos.AsNoTracking()
                .Select(s => new GetAllCourtVm
                {
                    CourtId = s.CourtId,
                    CourtName = s.CourtName,
                    CourtNo = s.CourtNo,
                    //CourtAddress = s.CourtAddress,
                    Email = s.Email,
                    Website = s.Website,
                    Phone = s.Phone,
                    Fax = s.Fax,
                    DistrictId = s.DistrictId
                }).OrderBy(o=> o.CourtName).ToListAsync();
            return data;
        }

        public static string GetDistrics(int id, CoreERPContext _coreERPContext)
        {
            return _coreERPContext.CommonDistricts.Where(f => f.DistrictId == id).FirstOrDefault().DistrictName;
        }

        public async Task<GridEntity<GetAllCourtGridVm>> GetAllCourtGrid(GridOptions options)
        {
            try
            {
                var data = (from a in _dbContext.CourtInfos
                            join b in _dbContext.DistrictWiseJurisdictions on a.CourtId equals b.CourtId
                            join c in _dbContext.JurisdictionInfos on b.JurisdictionId equals c.JurisdictionId
                            group new 
                            { 
                                a.CourtId, 
                                a.CourtName, 
                                a.CourtNo, 
                                a.Email, 
                                a.Phone,
                                a.Website,
                                a.Fax, 
                                a.DistrictId, 
                                c.JurisdictionName }
                            by new { 
                                a.CourtId,
                                a.CourtName,
                                a.CourtNo,
                                a.Email,
                                a.Phone,
                                a.Website,
                                a.Fax,
                                a.DistrictId }
                            into g
                            select new GetAllCourtGridVm
                            {
                                CourtId = g.Key.CourtId,
                                CourtName = g.Key.CourtName,
                                CourtNo = g.Key.CourtNo,
                                Email = g.Key.Email,
                                Phone = g.Key.Phone,
                                Website = g.Key.Website,
                                Fax = g.Key.Fax,
                                //JurisdictionId = g.Key.JurisdictionId,
                                DistrictId = g.Key.DistrictId,
                                DistrictName = g.Key.DistrictId == null ? "" : GetDistrics((int)g.Key.DistrictId, _coreERPContext),
                                JurisdictionName = string.Join(", ", g.Select(i=> i.JurisdictionName))
                            }).OrderBy(o => o.CourtName).ToList().AsQueryable();
                var res = KendoGrid<GetAllCourtGridVm>.DataSource(options, data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<CourtInfo> GetCourtById(int courtId)
        {
            return await _dbContext.CourtInfos.AsNoTracking().Where(f => f.CourtId == courtId).FirstOrDefaultAsync();
        }

        public async Task<bool> IsCourtNameExist(int id, string name)
        {
            try
            {
                var existsdata = (await _dbContext.CourtInfos.AsNoTracking()
                                .Where(a => id == 0 ? a.CourtName == name : a.CourtName == name && a.CourtId != id)
                                .OrderBy(o => o.CourtName).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<CourtInfo> UpdateCourtInfo(CourtInfo courtInfo)
        {
            int courtId = courtInfo.CourtId;

            var districtWiseJurisdictions = courtInfo.DistrictWiseJurisdictions.ToList();
            var dwj = districtWiseJurisdictions.Select(s => s.DistrictWiseJurisdictionId).ToList();
            Removedistricjuri(dwj, courtId);

            _dbContext.Entry(courtInfo).State = EntityState.Modified;
            _dbContext.DistrictWiseJurisdictions.UpdateRange(districtWiseJurisdictions);
            await _dbContext.SaveChangesAsync();
            return courtInfo;
        }

        private void Removedistricjuri(List<int> dwj, int courtId)
        {
            var removeData = _dbContext.DistrictWiseJurisdictions.Where(s => s.CourtId == courtId && !dwj.Contains(s.DistrictWiseJurisdictionId)).ToList();
            _dbContext.DistrictWiseJurisdictions.RemoveRange(removeData);
            _dbContext.SaveChanges();
        }

        public async Task<List<GetAllDistrictByCourtIdVm>> GetAllDistrictByCourtId(int courtId)
        {
            try
            {
                var data = await _dbContext.CourtInfos.AsNoTracking()
                    .Where(f => f.CourtId == courtId)
                    .Select(s => new GetAllDistrictByCourtIdVm
                    {
                        DistrictId = s.DistrictId,
                        DistrictName = GetDistrics((int)s.DistrictId, _coreERPContext),

                    }).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
        
    }
}
