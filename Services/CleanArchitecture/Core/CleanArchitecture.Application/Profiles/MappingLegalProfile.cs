using AutoMapper;
using CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Command.CreateUpdateCaseFileMaster;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCourtByFileMasterId;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMaster;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetCaseFilesByFileMasterId;
using CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands;
using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetAllCompany;
using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetUnitByCompanyId;
using CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllDistrictByCourtId;
using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.GetCourtByDistrictAndJurisdictionId;
using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.Queries;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Command.CreateUpdateExpense;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseInfo;
using CleanArchitecture.Application.Features.Legal.File_Type.Command.CreateUpdateFileType;
using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileType;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Command.CreateUpdateJurisdiction;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdiction;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionByCourtId;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Command.CreateUpdateLawer;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyer;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Command.CreateUpdateMatter;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterInfo;
using CleanArchitecture.Application.Features.Legal.OnBehalfOfInfo.Queries.GetAllOnBehalfOf;
using CleanArchitecture.Application.Features.Legal.Status_Info.Queries.GetAllStatus;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Command.CreateUpdateDiary;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiary;
using CleanArchitecture.Domain.CoreErpModel;
using CleanArchitecture.Domain.LegalModel;

namespace Merchandising.Application.Profiles
{
    public class MappingLegalProfile : Profile
    {
        public MappingLegalProfile()
        {

            //Court Info
            CreateMap<CourtInfo, CreateUpdateCourtDto>().ReverseMap();
            CreateMap<CourtInfo, GetAllCourtVm>().ReverseMap();
            CreateMap<CourtInfo, GetAllDistrictByCourtIdVm>().ReverseMap();

            //Lawer Info
            CreateMap<LawyerInfo, CreateUpdateLawerDto>().ReverseMap();
            CreateMap<LawyerInfo, GetAllLawyerVm>().ReverseMap();

            //Jurisdiction Info
            CreateMap<JurisdictionInfo, CreateUpdateJurisdictionDto>().ReverseMap();
            CreateMap<JurisdictionInfo, GetAllJurisdictionVm>().ReverseMap();
            CreateMap<JurisdictionInfo, GetAllJurisdictionByCourtIdVm>().ReverseMap();

            //File Type
            CreateMap<FileType, GetAllFileTypeVm>().ReverseMap();
            CreateMap<FileType, CreateUpdateFileTypeDto>().ReverseMap();

            //Case Type
            CreateMap<CaseType, CreateUpdateCaseTypeDto>().ReverseMap();
            CreateMap<CaseType, GetAllCaseTypeVm>().ReverseMap();

            //MAtter Info
            CreateMap<MatterInfo, CreateUpdateMatterDto>().ReverseMap();
            CreateMap<MatterInfo, GetAllMatterVm>().ReverseMap();

            //Case File Master
            CreateMap<CaseFileMaster, CreateUpdateCaseFileMasterDto>().ReverseMap();
            CreateMap<CaseFileMaster, GetAllFileMasterVm>().ReverseMap();
            CreateMap<CaseFileMaster, GetAllFileMasterByRegNoVm>().ReverseMap();
            CreateMap<CaseFileMaster, GetCaseFilesByFileMasterIdVm>().ReverseMap();
            CreateMap<CaseFileMaster, GetAllCourtByFileMasterIdVm>().ReverseMap();
            CreateMap<CaseFileMaster, GetAllCaseFileGridByIdsVm>().ReverseMap();

            //CmnDocument File
            CreateMap<CmnDocument, DocumentVM>().ReverseMap();

            //Update Diary
            CreateMap<UpdateDiary, CreateUpdateDiaryDto>().ReverseMap();
            CreateMap<UpdateDiary, GetAllUpdateDiaryVm>().ReverseMap();

            //Expense Info
            CreateMap<ExpensesInfo, CreateUpdateExpenseDto>().ReverseMap();
            CreateMap<ExpensesInfo, GetAllExpenseInfoVm>().ReverseMap();

            //DistrictWiseJurisdiction
            CreateMap<DistrictWiseJurisdiction, GetAllDistrictJurisdictionByCourtVm>().ReverseMap();
            CreateMap<DistrictWiseJurisdiction, GetCourtByDistrictAndJurisdictionIdVm>().ReverseMap();

            //Status Info
            CreateMap<StatusInfo, GetAllStatusVm>().ReverseMap();

            //Company
            CreateMap<CommonCompany, GetAllCompanyVm>().ReverseMap();
            CreateMap<CommonUnit, GetUnitByCompanyIdVm>().ReverseMap();

            //OnBeHalfOf
            CreateMap<OnBehalfOf, GetAllOnBehalfOfVm>().ReverseMap();



        }
    }
}
