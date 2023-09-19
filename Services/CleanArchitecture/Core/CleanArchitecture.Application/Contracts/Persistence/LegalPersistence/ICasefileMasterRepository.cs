using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCourtByFileMasterId;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMaster;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetCaseFilesByFileMasterId;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface ICasefileMasterRepository : IAsyncLegalRepository<CaseFileMaster>
    {
        Task<CaseFileMaster> GetCaseFileById(int fileMasterId);
        string GetLastGenaratedCaseFile();
        Task<bool> IsCaseFileExist(int id, string caseNo);
        Task<List<GetAllFileMasterVm>> GetAllCaseFile();
        Task<List<GetAllFileMasterByRegNoVm>> GetAllCaseFileByRegNo(string regNo);
        Task<GridEntity<GetAllCaseFileMasterGridVm>> GetAllCaseFileGrid(GridOptions options);
        Task<List<GetCaseFilesByFileMasterIdVm>> GetCaseFilesByFileMasterId(int fileMasterId);
        Task<List<GetAllCourtByFileMasterIdVm>> GetAllCourtByFileMasterId(int fileMasterId);
        Task<GridEntity<GetAllCaseFileGridByIdsVm>> GetAllCaseFileGridByIds(GridOptions options, int? fileTypeId, int? CourtId, int? statusId, int? UnitId);
    }
}
