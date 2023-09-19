using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
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
    public class CaseTypeRepository : LegalBaseRepository<CaseType>, ICaseTypeRepository
    {
        public CaseTypeRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GetAllCaseTypeVm>> GetAllCaseType()
        {
            var data = await _dbContext.CaseTypes.AsNoTracking()
                .Select(s => new GetAllCaseTypeVm
                {
                    CaseTypeId = s.CaseTypeId,
                    CaseTypeName = s.CaseTypeName
                }).OrderBy(o=> o.CaseTypeName).ToListAsync();
            return data;
        }

        public async Task<GridEntity<GetAllCaseTypeGridVm>> GetAllCaseTypeGrid(GridOptions options)
        {
            var data = _dbContext.CaseTypes.AsNoTracking()
                .Select(s => new GetAllCaseTypeGridVm
                {
                    CaseTypeId = s.CaseTypeId,
                    CaseTypeName = s.CaseTypeName
                }).OrderBy(o => o.CaseTypeName).AsQueryable();
            var res = KendoGrid<GetAllCaseTypeGridVm>.DataSource(options, data);
            return await Task.FromResult(res);
        }

        public async Task<CaseType> GetCaseTypeById(int caseTypeId)
        {
            return await _dbContext.CaseTypes.AsNoTracking().Where(f => f.CaseTypeId == caseTypeId).FirstOrDefaultAsync();
        }

        public async Task<bool> IsCaseTypeExist(int id, string name)
        {
            try
            {
                var existsdata = (await _dbContext.CaseTypes.AsNoTracking()
                                .Where(a => id == 0 ? a.CaseTypeName == name : a.CaseTypeName == name && a.CaseTypeId != id)
                                .OrderBy(o => o.CaseTypeName).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
