using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Status_Info.Queries.GetAllStatus;
using CleanArchitecture.Domain.LegalModel;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class StatusRepository : LegalBaseRepository<StatusInfo>, IStatusRepository
    {
        public StatusRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GetAllStatusVm>> GetAllStatus()
        {
            try
            {
                var data = await _dbContext.StatusInfos.AsNoTracking()
                    .Select(s => new GetAllStatusVm
                    {
                        StatusId = s.StatusId,
                        StatusName = s.StatusName
                    }).OrderBy(o=> o.StatusId).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
