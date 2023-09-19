using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterGrid;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterInfo;
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
    public class MatterRepository : LegalBaseRepository<MatterInfo>, IMatterRepository
    {
        public MatterRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GetAllMatterVm>> GetAllMAtter()
        {
            var data = await _dbContext.MatterInfos.AsNoTracking()
                .Select(s => new GetAllMatterVm
                {
                    MatterId = s.MatterId,
                    MatterName = s.MatterName,
                    Discription = s.Discription
                }).OrderBy(o => o.MatterName).ToListAsync();
            return data;
        }

        public async Task<GridEntity<GetAllMatterGridVm>> GetAllMatterGrid(GridOptions options)
        {
            try
            {
                var data = _dbContext.MatterInfos.AsNoTracking()
                    .Select(s => new GetAllMatterGridVm
                    {
                        MatterId = s.MatterId,
                        MatterName = s.MatterName,
                        Discription = s.Discription
                    }).OrderBy(o => o.MatterName).AsQueryable();
                var res = KendoGrid<GetAllMatterGridVm>.DataSource(options, data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        
        }

        public async Task<MatterInfo> GetMatterById(int matterId)
        {
            return await _dbContext.MatterInfos.AsNoTracking().Where(f => f.MatterId == matterId).FirstOrDefaultAsync();
        }

        public async Task<bool> IsMatterExist(int id, string name)
        {
            try
            {
                var existsdata = (await _dbContext.MatterInfos.AsNoTracking()
                                .Where(a => id == 0 ? a.MatterName == name : a.MatterName == name && a.MatterId != id)
                                .OrderBy(o => o.MatterName).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
