using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetAllCompany;
using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetUnitByCompanyId;
using CleanArchitecture.Domain.CoreErpModel;
using CleanArchitecture.Domain.LegalModel;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class CompanyRepository : LegalBaseRepository<CommonCompany>, ICompanyRepository
    {
        private readonly CoreERPContext _coreERPContext;
        public CompanyRepository(LEGALDBContext dbContext, CoreERPContext coreERPContext) : base(dbContext)
        {
            _coreERPContext = coreERPContext ?? throw new ArgumentNullException(nameof(coreERPContext));

        }

        public async Task<List<GetAllCompanyVm>> GetAllCompany()
        {
            try
            {
                var data = await _coreERPContext.CommonCompanies.AsNoTracking()
                    .Where(f => f.IsActive == true)
                    .Select(s => new GetAllCompanyVm
                    {
                        CompanyId = s.CompanyId,
                        CompanyName = s.CompanyName
                    }).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<List<GetUnitByCompanyIdVm>> GetUnitByCompanyId(int companyId)
        {
            try
            {
                var data = await _coreERPContext.CommonUnits.AsNoTracking()
                    .Where(f => f.IsActive == true && f.CompanyId == companyId)
                    .Select(s => new GetUnitByCompanyIdVm
                    {
                        UnitId = s.UnitId,
                        UnitName = s.UnitName
                    }).OrderBy(o => o.UnitName).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
