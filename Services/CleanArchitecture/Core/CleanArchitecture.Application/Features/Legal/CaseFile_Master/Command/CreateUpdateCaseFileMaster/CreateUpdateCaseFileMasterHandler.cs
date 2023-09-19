using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Command.CreateUpdateCaseFileMaster
{
    public class CreateUpdateCaseFileMasterHandler : IRequestHandler<CreateUpdateCaseFileMasterCommand,CreateUpdateCaseFileMasterResponse>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;
        private readonly ICmnDocumentRepository _documentRepository;
        private readonly ILogger<CreateUpdateCaseFileMasterHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateCaseFileMasterHandler(ICasefileMasterRepository casefileMasterRepository, ICmnDocumentRepository documentRepository, ILogger<CreateUpdateCaseFileMasterHandler> logger, IMapper mapper)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
            _documentRepository = documentRepository ?? throw new ArgumentNullException(nameof(documentRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateCaseFileMasterResponse> Handle(CreateUpdateCaseFileMasterCommand request, CancellationToken cancellationToken)
        {
            var fileResponse = new CreateUpdateCaseFileMasterResponse();
            try
            {
                var validator = new CreateUpdateCaseFileMasterValidator(_casefileMasterRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    fileResponse.Success = false;
                    fileResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        fileResponse.Message = fileResponse.Message + Environment.NewLine + error.ErrorMessage;
                        fileResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(fileResponse.Message);
                }

                if (fileResponse.Success)
                {
                    var fileMaster = new CaseFileMaster
                    {
                        FileMasterId = request.FileMasterId,
                        RegNo = request.RegNo == null || request.RegNo == string.Empty ? GenerateRegNo() : request.RegNo,
                        CaseNo = request.CaseNo,
                        CourtId = request.CourtId,
                        MatterId = request.MatterId,
                        AssignLawyer = request.AssignLawyer,
                        FillingLawyer = request.FillingLawyer,
                        OppositeLawyer = request.OppositeLawyer,
                        FileTypeId = request.FileTypeId,
                        CompanyId = request.CompanyId,
                        UnitId = request.UnitId,
                        Discription = request.Discription,
                        IsPublish = request.IsPublish,
                        IsDeleted = false,
                        Petitioner = request.Petitioner,
                        PetitionerContact = request.PetitionerContact,
                        OppositeParty = request.OppositeParty,
                        OppositePartyContact = request.OppositePartyContact,
                        FillingLawyerContact = request.FillingLawyerContact,
                        OppositeLawyerContact = request.OppositeLawyerContact,
                        StatusId = request.StatusId,
                        StatusDate = request.StatusDate == "" ? null : DateTime.Parse(request.StatusDate),
                        OnBehalfOfId = request.OnBehalfOfId

                    };
                    if (request.FileMasterId == 0)
                    {
                        fileMaster.CreatedAt = DateTime.Now;
                        fileMaster.CreatedBy = request.CreatedBy;                        
                        
                        fileMaster = await _casefileMasterRepository.AddAsync(fileMaster);
                        saveDocument(request.DocumentVms, fileMaster.FileMasterId);

                        fileResponse.Message = fileMaster.RegNo + " Saved Successfully!";
                    }
                    else
                    {
                        var fileMasterId = await _casefileMasterRepository.GetCaseFileById(request.FileMasterId);
                        
                        if (fileMasterId != null && (request.IsDeleted == false || request.IsDeleted == null))
                        {
                            fileMaster.CreatedBy = fileMasterId.CreatedBy;
                            fileMaster.CreatedAt = fileMasterId.CreatedAt;
                            fileMaster.UpdatedBy = request.UpdatedBy;
                            fileMaster.UpdatedAt = DateTime.Now;
                            await _casefileMasterRepository.Update(fileMaster);
                            saveDocument(request.DocumentVms, request.FileMasterId);
                            fileResponse.Message = fileMaster.RegNo + " Updated Successfully!";
                        }
                        else if (fileMasterId != null && request.IsDeleted == true)
                        {
                            fileMaster.IsDeleted = true;
                            fileMaster.DeletedBy = request.DeletedBy;
                            await _casefileMasterRepository.Update(fileMaster);
                            saveDocument(request.DocumentVms, request.FileMasterId);
                            fileResponse.Message = "Deleted Successfully!";
                        }
                        else
                        {
                            fileResponse.Message = "Data Not Found!";
                        }
                    }
                    fileResponse.masterDto = _mapper.Map<CreateUpdateCaseFileMasterDto>(fileMaster);

                }
                _logger.LogInformation(fileResponse.Message);
                return fileResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        private void saveDocument(ICollection<DocumentVM> requestDocumentVms, int fileMasterId)
        {
            foreach (var item in requestDocumentVms)
            {
                item.ModuleMasterId = fileMasterId;
                _documentRepository.AddRemoveDocument(item);
            }
        }

        public string GenerateRegNo()
        {
            string fmt = "000.##";
            string lastGenratedNo = _casefileMasterRepository.GetLastGenaratedCaseFile();
            int num = lastGenratedNo == "" ? 1 : Convert.ToInt32(lastGenratedNo[4..]) + 1;
            string newGeneratedNo = "Reg_" + (num.ToString(fmt));
            return newGeneratedNo;
        }

        //private void saveDocument(ICollection<DocumentVM> requestDocumentVms, Guid flmid)
        //{
            
        //}

    }
}
