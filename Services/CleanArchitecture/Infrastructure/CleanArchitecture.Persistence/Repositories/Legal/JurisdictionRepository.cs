using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdiction;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionByCourtId;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionGrid;
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
    public class JurisdictionRepository : LegalBaseRepository<JurisdictionInfo>, IJurisdictionRepository
    {
        public JurisdictionRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GetAllJurisdictionVm>> GetAllJurisdiction()
        {
            var data = await _dbContext.JurisdictionInfos.AsNoTracking()
                .Select(s => new GetAllJurisdictionVm
                {
                    JurisdictionId = s.JurisdictionId,
                    JurisdictionName = s.JurisdictionName
                }).OrderBy(o => o.JurisdictionName).ToListAsync();
            return data;
        }

        public async Task<List<GetAllJurisdictionByCourtIdVm>> GetAllJurisdictionByCourtId(int courtId)
        {
            try
            {
                var data = await (from a in _dbContext.DistrictWiseJurisdictions
                            join b in _dbContext.JurisdictionInfos on a.JurisdictionId equals b.JurisdictionId
                            where a.CourtId == courtId
                            select new GetAllJurisdictionByCourtIdVm
                            {
                                JurisdictionId = a.JurisdictionId,
                                JurisdictionName = b.JurisdictionName

                            }).OrderBy(o=> o.JurisdictionName).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<GridEntity<GetAllJurisdictionGridVm>> GetAllJurisdictionGrid(GridOptions options)
        {
            try
            {
                var data = _dbContext.JurisdictionInfos.AsNoTracking()
                    .Select(s=> new GetAllJurisdictionGridVm
                    {
                        JurisdictionId = s.JurisdictionId,
                        JurisdictionName = s.JurisdictionName
                    }).AsQueryable();
                var res = KendoGrid<GetAllJurisdictionGridVm>.DataSource(options, data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<JurisdictionInfo> GetJurisdictionById(int jurisdictionId)
        {
            return await _dbContext.JurisdictionInfos.AsNoTracking().Where(f => f.JurisdictionId == jurisdictionId).FirstOrDefaultAsync();
        }

        public async Task<bool> IsJurisdictionNameExist(int id, string name)
        {
            try
            {
                var existsdata = (await _dbContext.JurisdictionInfos.AsNoTracking()
                                .Where(a => id == 0 ? a.JurisdictionName == name : a.JurisdictionName == name && a.JurisdictionId != id)
                                .OrderBy(o => o.JurisdictionName).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
