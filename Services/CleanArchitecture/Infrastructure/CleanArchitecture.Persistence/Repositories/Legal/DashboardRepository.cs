using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Dashboard;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class DashboardRepository : LegalBaseRepository<DashboardCasesVm>, IDashboardRepository
    {
        public DashboardRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<GridEntity<DashboardCasesVm>> GetallOverDatedCase(GridOptions options)
        {
            try

            {
                //var upcoming = GetUpcomingData(FileMasterId);

                var data = _dbContext.UpdateDiaries.AsNoTracking()
                   .Include(i => i.FileMaster)
                   .Where(f => f.NextDate < DateTime.Now.Date && f.FileMaster.IsDeleted == false && f.StatusId != 2)
                   .Select(s => new DashboardCasesVm
                   {
                       FileMasterId = s.FileMasterId,
                       RegNo = s.FileMaster.RegNo,
                       FileTypeId = s.FileMaster.FileTypeId,
                       FileTypeName = s.FileMaster.FileType.FileTypeName,
                       CourtId = s.FileMaster.CourtId,
                       CourtName = s.FileMaster.Court.CourtName,
                       CaseNo = s.FileMaster.CaseNo,
                       AssignLawyer = s.FileMaster.AssignLawyer,
                       AssignLawyerName = s.FileMaster.AssignLawyerNavigation.LawyerName,
                       Petitioner = s.FileMaster.Petitioner,
                       OppositeParty = s.FileMaster.OppositeParty,
                       DiaryId = s.DiaryId,
                       PreviousDate = s.PreviousDate,
                       NextDate = s.NextDate,
                       NextDateFor = s.NextDateFor,
                       IsPublish = s.FileMaster.IsPublish,
                       StatusId = s.StatusId,
                       StatusName = s.Status.StatusName
                   }).OrderBy(o => o.NextDate).AsQueryable();
                var res = KendoGrid<DashboardCasesVm>.DataSource(options,data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<GridEntity<DashboardCasesVm>> GetallUpcomingCase(GridOptions options)
        {
            try
            {                
                var data = (from a in _dbContext.UpdateDiaries
                            join b in _dbContext.CaseFileMasters on a.FileMasterId equals b.FileMasterId
                            join c in _dbContext.LawyerInfos on b.AssignLawyer equals c.LawyerId
                            where(a.NextDate > DateTime.Now.Date && b.IsDeleted == false && b.StatusId != 2)
                            group new
                            {
                                a.FileMasterId,
                                b.RegNo,
                                b.FileTypeId,
                                b.FileType.FileTypeName,
                                b.CourtId,
                                b.Court.CourtName,
                                b.CaseNo,
                                b.AssignLawyer,
                                c.LawyerName,
                                b.Petitioner,
                                b.OppositeParty,
                                a.DiaryId,
                                a.PreviousDate,
                                a.PreviousDateFor,
                                a.NextDate,
                                a.NextDateFor,
                                b.IsPublish,
                                b.StatusId,
                                b.Status.StatusName
                            }
                            by new
                            {
                                a.FileMasterId,
                                b.RegNo,
                                b.FileTypeId,
                                b.FileType.FileTypeName,
                                b.CourtId,
                                b.Court.CourtName,
                                b.CaseNo,
                                b.AssignLawyer,
                                c.LawyerName,
                                b.Petitioner,
                                b.OppositeParty,
                                a.DiaryId,
                                a.PreviousDate,
                                a.PreviousDateFor,
                                a.NextDate,
                                a.NextDateFor,
                                b.IsPublish,
                                b.StatusId,
                                b.Status.StatusName
                            }
                            into g
                            select new DashboardCasesVm
                            {
                                FileMasterId = g.Key.FileMasterId,
                                RegNo = g.Key.RegNo,
                                FileTypeId = g.Key.FileTypeId,
                                FileTypeName = g.Key.FileTypeName,
                                CourtId = g.Key.CourtId,
                                CourtName = g.Key.CourtName,
                                CaseNo = g.Key.CaseNo,
                                AssignLawyer = g.Key.AssignLawyer,
                                AssignLawyerName = g.Key.LawyerName,
                                IsPublish = g.Key.IsPublish,
                                Petitioner = g.Key.Petitioner,
                                OppositeParty = g.Key.OppositeParty,
                                DiaryId = g.Key.DiaryId,
                                PreviousDate = g.Key.PreviousDate,
                                NextDate = g.Key.NextDate,
                                NextDateFor = g.Key.NextDateFor,
                                StatusId = g.Key.StatusId,
                                StatusName = g.Key.StatusName
                            }).OrderBy(o => o.NextDate).AsQueryable();
                var res = KendoGrid<DashboardCasesVm>.DataSource(options, data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<int> GetTotalLADDisposed()
        {
            try
            {
                return _dbContext.CaseFileMasters.AsNoTracking().Where(w => w.IsDeleted == false && w.FileTypeId == 6 && w.StatusId == 2).Select(s => s.CaseNo).Count();

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<int> GetTotalLADPending()
        {
            try
            {
                return _dbContext.CaseFileMasters.AsNoTracking().Where(w => w.IsDeleted == false && w.FileTypeId == 6 && w.StatusId == 1).Select(s => s.CaseNo).Count();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<int> GetTotalLDCDisposed()
        {
            try
            {
                return _dbContext.CaseFileMasters.AsNoTracking().Where(f => f.IsDeleted == false && f.FileTypeId == 1 && f.StatusId == 2).Select(s => s.CaseNo).Count();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<int> GetTotalLDCPending()
        {
            try
            {
                return _dbContext.CaseFileMasters.AsNoTracking().Where(f => f.IsDeleted == false && f.FileTypeId == 1 && f.StatusId == 1).Select(s => s.CaseNo).Count();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<int> GetTotalLHDDisposed()
        {
            return _dbContext.CaseFileMasters.AsNoTracking().Where(w => w.IsDeleted == false && w.FileTypeId == 5 && w.StatusId == 2).Select(s => s.CaseNo).Count();
        }

        public async Task<int> GetTotalLHDPending()
        {
            return _dbContext.CaseFileMasters.AsNoTracking().Where(w => w.IsDeleted == false && w.FileTypeId == 5 && w.StatusId == 1).Select(s => s.CaseNo).Count();
        }

        public async Task<int> GetTotalLLCDisposed()
        {
            try
            {
                return _dbContext.CaseFileMasters.AsNoTracking().Where(w => w.IsDeleted == false && w.FileTypeId == 4 && w.StatusId == 2 ).Select(s => s.CaseNo).Count();

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<int> GetTotalLLCPending()
        {
            try
            {
                return _dbContext.CaseFileMasters.AsNoTracking().Where(w => w.IsDeleted == false && w.FileTypeId == 4 && w.StatusId == 1).Select(s => s.CaseNo).Count();

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<List<DashboardCasesVm>> GetUpcomingData(int fileMasterId)
        {
            try
            {
                var list =await _dbContext.UpdateDiaries.AsNoTracking()
                    .Where(f => f.NextDate >= DateTime.Now.Date && f.StatusId != 2 && f.FileMasterId == fileMasterId)
                    .Select(s=> new DashboardCasesVm
                    {
                        FileMasterId = s.FileMasterId,
                        RegNo = s.FileMaster.RegNo,
                        FileTypeId = s.FileMaster.FileTypeId,
                        FileTypeName = s.FileMaster.FileType.FileTypeName,
                        CourtId = s.FileMaster.CourtId,
                        CourtName = s.FileMaster.Court.CourtName,
                        CaseNo = s.FileMaster.CaseNo,
                        AssignLawyer = s.FileMaster.AssignLawyer,
                        AssignLawyerName = s.FileMaster.AssignLawyerNavigation.LawyerName,
                        Petitioner = s.FileMaster.Petitioner,
                        OppositeParty = s.FileMaster.OppositeParty,
                        DiaryId = s.DiaryId,
                        PreviousDate = s.PreviousDate,
                        NextDate = s.NextDate,
                        NextDateFor = s.NextDateFor,
                        IsPublish = s.FileMaster.IsPublish,
                        StatusId = s.StatusId,
                        StatusName = s.Status.StatusName
                    }).ToListAsync();
                return list;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
