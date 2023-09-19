using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCourtByFileMasterId;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMaster;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetCaseFilesByFileMasterId;
using CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands;
using CleanArchitecture.Domain.CoreErpModel;
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
    public class CaseFileMasterRepository : LegalBaseRepository<CaseFileMaster>, ICasefileMasterRepository
    {
        private readonly CoreERPContext _coreERPContext;

        public CaseFileMasterRepository(LEGALDBContext dbContext, CoreERPContext coreERPContext) : base(dbContext)
        {
            _coreERPContext = coreERPContext ?? throw new ArgumentNullException(nameof(coreERPContext));
        }

        //public CaseFileMasterRepository(LEGALDBContext dbContext) : base(dbContext)
        //{
        //}

        public async Task<List<GetAllFileMasterVm>> GetAllCaseFile()
        {
            try
            {
                var data = await _dbContext.CaseFileMasters.AsNoTracking()
                    .Include(i => i.FileType)
                    // .Include(i => i.OppositeLawyerNavigation)
                    //.Include(i => i.Jurisdiction)
                    .Include(i => i.Court)
                    //.Include(i => i.FillingLawyerNavigation)
                    .Include(i => i.AssignLawyerNavigation)
                    .Include(i => i.Matter)
                    .Select(s => new GetAllFileMasterVm
                    {
                        FileMasterId = s.FileMasterId,
                        RegNo = s.RegNo,
                        FileTypeId = s.FileTypeId,
                        FileTypeName = s.FileType.FileTypeName,
                        //DistrictId = s.DistrictId,
                        //DistrictName = GetDistrics(s.DistrictId, _coreERPContext),
                        OppositeLawyer = s.OppositeLawyer,
                        OppositeLawyerContact = s.OppositeLawyerContact,
                        //JurisdictionId = s.JurisdictionId,
                        //JurisdictionName = s.Jurisdiction.JurisdictionName,
                        CourtId = s.CourtId,
                        CourtName = s.Court.CourtName,
                        CaseNo = s.CaseNo,
                        FillingLawyer = s.FillingLawyer,
                        FillingLawyerContact = s.FillingLawyerContact,
                        AssignLawyer = s.AssignLawyer,
                        AssignLawyerName = s.AssignLawyerNavigation.LawyerName,
                        Discription = s.Discription,
                        IsPublish = s.IsPublish,
                        CreatedBy = s.CreatedBy,
                        CreatedAt = s.CreatedAt,
                        UpdatedAt = s.UpdatedAt,
                        MatterId = s.MatterId,
                        MatterName = s.Matter.MatterName,
                        CompanyId = s.CompanyId,
                        CompanyName = s.CompanyId == null ? "" : GetCompany((int)s.CompanyId,_coreERPContext),
                        UnitId = s.UnitId,
                        UnitName = s.UnitId == null || s.UnitId == 0 ? "" : GetUnits((int)s.UnitId, _coreERPContext),
                        Petitioner = s.Petitioner,
                        OppositeParty = s.OppositeParty,
                        PetitionerContact = s.PetitionerContact,
                        OppositePartyContact = s.OppositePartyContact,
                        UpdatedBy = s.UpdatedBy,
                        StatusId = s.StatusId,
                        StatusName = s.Status.StatusName,
                        StatusDate = s.StatusDate,
                        OnBehalfOfId = s.OnBehalfOfId,
                        OnBehalfOfName = s.OnBehalfOf.OnBehalfOfName
                    }).OrderByDescending(o => o.RegNo).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
        public static string GetDistrics(int id, CoreERPContext _coreERPContext)
        {
            return _coreERPContext.CommonDistricts.Where(f => f.DistrictId == id).FirstOrDefault().DistrictName;
        }

        public static string GetUnits(int id, CoreERPContext _coreERPContext)
        {
            return _coreERPContext.CommonUnits.Where(f => f.UnitId == id).FirstOrDefault().UnitName;
        }

        public static string GetCompany(int id, CoreERPContext _coreERPContext)
        {
            return _coreERPContext.CommonCompanies.Where(f => f.CompanyId == id).FirstOrDefault().CompanyName;
        }
        public async Task<List<GetAllFileMasterByRegNoVm>> GetAllCaseFileByRegNo(string regNo)
        {
            try
            {
                var data = await _dbContext.CaseFileMasters.AsNoTracking()
                    .Include(i => i.Court)
                    .Where(f => f.RegNo.Contains(regNo) || f.CaseNo.Contains(regNo))
                    .Select(s => new GetAllFileMasterByRegNoVm
                    {
                        FileMasterId = s.FileMasterId,
                        RegNo = s.RegNo,
                        CourtId = s.CourtId,
                        CourtName = s.Court.CourtName,
                        CaseNo = s.CaseNo
                    }).OrderBy(o => o.RegNo).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<GridEntity<GetAllCaseFileMasterGridVm>> GetAllCaseFileGrid(GridOptions options)
        {
            try
            {
                var district = _coreERPContext.CommonDistricts.ToList();
                var unit = _coreERPContext.CommonUnits.ToList();
                var company = _coreERPContext.CommonCompanies.ToList();
                var data = _dbContext.CaseFileMasters.AsNoTracking()
                    .Include(i => i.FileType)
                    //.Include(i => i.Jurisdiction)
                    .Include(i => i.Court).ThenInclude(j => j.DistrictWiseJurisdictions).ThenInclude(k => k.Jurisdiction)
                    .Include(i => i.AssignLawyerNavigation)
                    .Include(i => i.Matter)
                    .Where(f => f.IsDeleted == false)
                    .Select(s => new GetAllCaseFileMasterGridVm
                    {
                        FileMasterId = s.FileMasterId,
                        RegNo = s.RegNo,
                        FileTypeId = s.FileTypeId,
                        FileTypeName = s.FileType.FileTypeName,
                        DistrictId = s.Court.DistrictId,
                        DistrictName = GetDistrics((int)s.Court.DistrictId, _coreERPContext),
                        OppositeLawyer = s.OppositeLawyer,
                        OppositeLawyerContact = s.OppositeLawyerContact,
                        //JurisdictionId = s.JurisdictionId,
                        CourtId = s.CourtId,
                        CourtName = s.Court.CourtName,
                        CaseNo = s.CaseNo,
                        FillingLawyer = s.FillingLawyer,
                        FillingLawyerContact = s.FillingLawyerContact,
                        AssignLawyer = s.AssignLawyer,
                        AssignLawyerName = s.AssignLawyerNavigation.LawyerName,
                        Discription = s.Discription,
                        IsPublish = s.IsPublish,
                        CreatedBy = s.CreatedBy,
                        CreatedAt = s.CreatedAt,
                        UpdatedAt = s.UpdatedAt,
                        MatterId = s.MatterId,
                        MatterName = s.Matter.MatterName,
                        CompanyId = s.CompanyId,
                        CompanyName = s.CompanyId == null ? "" : GetCompany((int)s.CompanyId,_coreERPContext),
                        UnitId = s.UnitId,
                        UnitName = s.UnitId == null || s.UnitId == 0 ? "" : GetUnits((int)s.UnitId, _coreERPContext),
                        UpdatedBy = s.UpdatedBy,
                        Petitioner = s.Petitioner,
                        PetitionerContact = s.PetitionerContact,
                        OppositeParty = s.OppositeParty,
                        OppositePartyContact = s.OppositePartyContact,
                        StatusId = s.StatusId,
                        StatusName = s.Status.StatusName,
                        StatusDate = s.StatusDate,
                        OnBehalfOfId = s.OnBehalfOfId,
                        OnBehalfOfName = s.OnBehalfOf.OnBehalfOfName,
                        FilesVm = _dbContext.CmnDocuments.Where(x => x.ModuleMasterId == s.FileMasterId && x.ModuleName == "Legal").AsNoTrackingWithIdentityResolution()
                                                    .Select(f => new FilesVm()
                                                    {
                                                        name = f.FileName,
                                                        size = (int)f.FileSize,
                                                        extension = f.FileExtension,
                                                        docId = f.DocumentId,
                                                        fileUniq = f.FileUniqueName
                                                    }).ToList()

                    }).OrderByDescending(o => o.RegNo).AsQueryable();

                var res = KendoGrid<GetAllCaseFileMasterGridVm>.DataSource(options, data);
                return await Task.FromResult(res);

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<CaseFileMaster> GetCaseFileById(int fileMasterId)
        {
            return await _dbContext.CaseFileMasters.AsNoTracking().Where(f => f.FileMasterId == fileMasterId).FirstOrDefaultAsync();
        }

        public string GetLastGenaratedCaseFile()
        {
            var data = _dbContext.CaseFileMasters.Where(f => f.RegNo.StartsWith("Reg_")).ToList();
            string REGNo = data.Count == 0 ? "" : data.OrderBy(o => o.RegNo).Select(s => s.RegNo).LastOrDefault().ToString();
            return REGNo;
        }

        public async Task<bool> IsCaseFileExist(int id, string caseNo)
        {
            try
            {
                var existsdata = (await _dbContext.CaseFileMasters.AsNoTracking()
                .Where(a => id == 0 ? a.CaseNo == caseNo : a.CaseNo == caseNo && a.FileMasterId != id)
                                .OrderBy(o => o.CaseNo).AnyAsync());
                return existsdata != false ? true : false;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<List<GetCaseFilesByFileMasterIdVm>> GetCaseFilesByFileMasterId(int fileMasterId)
        {
            try
            {
                var data = await _dbContext.CaseFileMasters.AsNoTracking()
                    .Where(f => f.FileMasterId == fileMasterId)
                    .Select(s => new GetCaseFilesByFileMasterIdVm
                    {
                        FileMasterId = s.FileMasterId,
                        RegNo = s.RegNo,
                        CourtId = s.CourtId,
                        CourtName = s.Court.CourtName,
                        CaseNo = s.CaseNo
                    }).OrderBy(o => o.RegNo).ThenBy(p => p.CaseNo).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<List<GetAllCourtByFileMasterIdVm>> GetAllCourtByFileMasterId(int fileMasterId)
        {
            try
            {
                var data = await _dbContext.CaseFileMasters.AsNoTracking()
                    .Include(i => i.Court)
                    .Where(f => f.FileMasterId == fileMasterId)
                    .Select(s => new GetAllCourtByFileMasterIdVm
                    {
                        CourtId = s.CourtId,
                        CourtName = s.Court.CourtName
                    }).OrderBy(o=> o.CourtName).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public async Task<GridEntity<GetAllCaseFileGridByIdsVm>> GetAllCaseFileGridByIds(GridOptions options, int? fileTypeId, int? CourtId, int? statusId, int? UnitId)
        {
            try
            {
                if(fileTypeId == 0 && CourtId==0 && statusId==0 && UnitId==0)
                {
                    var data1 = _dbContext.CaseFileMasters.AsNoTracking()

                    
                    .Select(s => new GetAllCaseFileGridByIdsVm
                    {
                        RegNo = s.RegNo,
                        CourtId = s.CourtId,
                        CourtName = s.Court.CourtName,
                        CaseNo = s.CaseNo,
                        Petitioner = s.Petitioner,
                        OppositeParty = s.OppositeParty,
                        PetitionerContact = s.PetitionerContact,
                        StatusId = s.StatusId,
                        StatusName = s.Status.StatusName
                    }).OrderBy(o => o.RegNo).AsQueryable();
                    var res1 = KendoGrid<GetAllCaseFileGridByIdsVm>.DataSource(options, data1);
                    return await Task.FromResult(res1);
                }
                else
                {

                }
                var data = _dbContext.CaseFileMasters.AsNoTracking()
                 
                    .Where(f=> f.FileTypeId == fileTypeId || f.CourtId == CourtId || f.StatusId == statusId || f.UnitId == UnitId)
                    .Select(s => new GetAllCaseFileGridByIdsVm
                    {
                        RegNo = s.RegNo,
                        CourtId = s.CourtId,
                        CourtName = s.Court.CourtName,
                        CaseNo = s.CaseNo,
                        Petitioner = s.Petitioner,
                        OppositeParty = s.OppositeParty,
                        PetitionerContact = s.PetitionerContact,
                        StatusId = s.StatusId,
                        StatusName = s.Status.StatusName
                    }).OrderBy(o=> o.RegNo).AsQueryable();
                var res = KendoGrid<GetAllCaseFileGridByIdsVm>.DataSource(options, data);
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
    }
