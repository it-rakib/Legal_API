using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyer;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyerGrid;
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
    public class LawyerRepository : LegalBaseRepository<LawyerInfo>, ILawyerInfoRepository
    {
        public LawyerRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GetAllLawyerVm>> GetAllLawyer()
        {
            var data = await _dbContext.LawyerInfos.AsNoTracking()
                .Select(s => new GetAllLawyerVm
                {
                    LawyerId = s.LawyerId,
                    LawyerName = s.LawyerName,
                    ContactNo = s.ContactNo,
                    Email = s.Email,
                    LawyerAddress = s.LawyerAddress
                }).OrderBy(o => o.LawyerName).ToListAsync();
            return data;
        }

        public async Task<GridEntity<GetAllLawyerGridVm>> GetAllLawyerGrid(GridOptions options)
        {
            var data = _dbContext.LawyerInfos.AsNoTracking()
                .Select(s => new GetAllLawyerGridVm
                {
                    LawyerId = s.LawyerId,
                    LawyerName = s.LawyerName,
                    ContactNo = s.ContactNo,
                    Email = s.Email,
                    LawyerAddress = s.LawyerAddress
                }).OrderBy(o=> o.LawyerName).AsQueryable();
            var res = KendoGrid<GetAllLawyerGridVm>.DataSource(options, data);
            return await Task.FromResult(res);
        }

        public async Task<LawyerInfo> GetLawyerById(int lawyerId)
        {
            return await _dbContext.LawyerInfos.AsNoTracking().Where(f => f.LawyerId == lawyerId).FirstOrDefaultAsync();
        }

        public async Task<bool> IsLawyerNameExist(int id, string name)
        {
            try
            {
                var existsdata = (await _dbContext.LawyerInfos.AsNoTracking()
                                .Where(a => id == 0 ? a.LawyerName == name : a.LawyerName == name && a.LawyerId != id)
                                .OrderBy(o => o.LawyerName).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
