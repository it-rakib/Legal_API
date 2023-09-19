using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiary;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiaryGrid;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Common.Service.CommonEntities.KendoGrid.UtilityCommon;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class UpdateDiaryRepository : LegalBaseRepository<UpdateDiary>, IUpdateDiaryRepository
    {
        public UpdateDiaryRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<GridEntity<GetAllUpdateDiaryGridVm>> GetAllDairyGrid(GridOptions options,int fileMasterId)
        {
            try
            {
                var data = _dbContext.UpdateDiaries.AsNoTracking()
                    .Include(i => i.FileMaster).ThenInclude(j=> j.Court)
                    .Where(f=> f.FileMasterId == fileMasterId)
                    //.Where(f=> f.StatusId == 1)
                    .Select(s => new GetAllUpdateDiaryGridVm
                    {
                        DiaryId = s.DiaryId,
                        FileMasterId = s.FileMasterId,
                        RegNo = s.FileMaster.RegNo,
                        CourtId = s.FileMaster.CourtId,
                        CourtName = s.FileMaster.Court.CourtName,
                        CaseNo = s.FileMaster.CaseNo,
                        PreviousDate = s.PreviousDate,
                        PreviousDateFor = s.PreviousDateFor,
                        NextDate = s.NextDate,
                        NextDateFor = s.NextDateFor,
                        StatusId = s.StatusId,
                        StatusName = s.Status.StatusName,                        
                        //Status = s.Status == 1 ? "Pending" : (s.Status == 2 ? "Disposed" : "Stayed same as 2"),
                        StatusDate = s.StatusDate,
                    }).OrderByDescending(o=> o.DiaryId).AsQueryable();
                var res = KendoGrid<GetAllUpdateDiaryGridVm>.DataSource(options, data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        
        }

        public async Task<List<GetAllUpdateDiaryVm>> GetAllUpdateDiary()
        {
            var data = await _dbContext.UpdateDiaries.AsNoTracking()
                .Select(s => new GetAllUpdateDiaryVm
                {
                    DiaryId = s.DiaryId,
                    FileMasterId = s.FileMasterId,
                    PreviousDate = s.PreviousDate,
                    PreviousDateFor = s.PreviousDateFor,
                    NextDate = s.NextDate,
                    NextDateFor = s.NextDateFor,
                    StatusId=s.StatusId,
                    StatusName=s.Status.StatusName,
                    //Status = s.Status == 1 ? "Pending" : (s.Status == 2 ? "Disposed" : "Stayed same as 2"),
                    StatusDate = s.StatusDate,
                    CreatedAt = s.CreatedAt,
                    CreatedBy = s.CreatedBy,
                    UpdatedAt = s.UpdatedAt,
                    UpdatedBy = s.UpdatedBy
                }).OrderBy(o=> o.NextDate).ThenBy(p=> p.PreviousDate).ToListAsync();
            return data;
        }

        public async Task<UpdateDiary> GetDiaryById(int diaryId)
        {
            try
            {
                return await _dbContext.UpdateDiaries.Where(f => f.DiaryId == diaryId).AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
 
                throw ex.InnerException;
            }
        }
        

        public async Task<bool> IsDiaryExist(string previousDate, string previousDateFor, string nextDate, string nextDateFor)
        {
            try
            {
                var data = await _dbContext.UpdateDiaries.AsNoTracking()
                    .Where(f => f.PreviousDate.ToString() == previousDate && f.PreviousDateFor == previousDateFor && f.NextDate.ToString() == nextDate && f.NextDateFor == nextDateFor).AnyAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
