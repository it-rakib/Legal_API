using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileType;
using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileTypeGrid;
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
    public class FileTypeRepository : LegalBaseRepository<FileType>, IFileTypeRepository
    {
        public FileTypeRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<GetAllFileTypeVm>> GetAllFileType()
        {
            var data = await _dbContext.FileTypes.AsNoTracking()
                .Select(s => new GetAllFileTypeVm
                {
                    FileTypeId = s.FileTypeId,
                    FileTypeName = s.FileTypeName,
                    FileTypeNo = s.FileTypeNo

                }).OrderBy(o => o.FileTypeName).ToListAsync();
            return data;
        }

        public async Task<GridEntity<GetAllFileTypeGridVm>> GetAllFileTypeGrid(GridOptions options)
        {
            var data = _dbContext.FileTypes.AsNoTracking()
                .Select(s=> new GetAllFileTypeGridVm
                {
                    FileTypeId = s.FileTypeId,
                    FileTypeName = s.FileTypeName,
                    FileTypeNo = s.FileTypeNo
                }).AsQueryable();
            var res = KendoGrid<GetAllFileTypeGridVm>.DataSource(options, data);
            return await Task.FromResult(res);
        }

        public async Task<FileType> GetFileTypeById(int fileTypeId)
        {
            return await _dbContext.FileTypes.AsNoTracking().Where(f => f.FileTypeId == fileTypeId).FirstOrDefaultAsync();
        }

        public async Task<bool> IsFileTypeExist(int id, string name)
        {
            try
            {
                var existsdata = (await _dbContext.FileTypes.AsNoTracking()
                .Where(a => id == 0 ? a.FileTypeName == name : a.FileTypeName == name && a.FileTypeId != id)
                                .OrderBy(o => o.FileTypeNo).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
