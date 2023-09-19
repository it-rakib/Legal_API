using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.OnBehalfOfInfo.Queries.GetAllOnBehalfOf;
using CleanArchitecture.Domain.LegalModel;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class OnBehalfOfRepository : LegalBaseRepository<OnBehalfOf>, IOnBehalfOfRepository
    {
        public OnBehalfOfRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GetAllOnBehalfOfVm>> GetAllOnBehalfOf()
        {
            try
            {
                var data = await _dbContext.OnBehalfOfs.AsNoTracking()
                    .Select(s => new GetAllOnBehalfOfVm
                    {
                        OnBehalfOfId = s.OnBehalfOfId,
                        OnBehalfOfName = s.OnBehalfOfName
                    }).OrderBy(o => o.OnBehalfOfName).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
