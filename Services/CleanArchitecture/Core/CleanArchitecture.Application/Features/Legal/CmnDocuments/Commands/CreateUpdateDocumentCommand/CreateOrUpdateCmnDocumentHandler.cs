using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands.CreateUpdateDocumentCommand
{
    public class CreateOrUpdateCmnDocumentHandler :IRequestHandler<CreateOrUpdateCmnDocumentCommand,CreateOrUpdateCmnDocumentResponse>
    {
        private readonly ICmnDocumentRepository _cmnDocumentRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateOrUpdateCmnDocumentHandler> _logger;

        public CreateOrUpdateCmnDocumentHandler(ICmnDocumentRepository cmnDocumentRepository, IMapper mapper, ILogger<CreateOrUpdateCmnDocumentHandler> logger)
        {
            _cmnDocumentRepository = cmnDocumentRepository ?? throw new ArgumentNullException(nameof(cmnDocumentRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<CreateOrUpdateCmnDocumentResponse> Handle(CreateOrUpdateCmnDocumentCommand request, CancellationToken cancellationToken)
        {
            var documentCommandResponse = new CreateOrUpdateCmnDocumentResponse();
            try
            {
                var validator = new CreateOrUpdateCmnDocumentValidator(_cmnDocumentRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    documentCommandResponse.Success = false;
                    documentCommandResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        documentCommandResponse.Message = documentCommandResponse.Message + "  " + error.ErrorMessage;
                        documentCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                        _logger.LogError(documentCommandResponse.Message);
                    }
                }
                if (documentCommandResponse.Success)
                {
                    var documentFile = new CmnDocument()
                    {
                        // DocumentId = request.DocumentId,
                        FileName = request.FileName,
                        ModuleName = request.ModuleName,
                        ModuleMasterId = request.ModuleMasterId,
                        FileSize = request.FileSize,
                        FileExtension = request.FileExtension,
                        FileUniqueName = request.FileUniqueName
                    };
                    if (request.ActionType == "Save")
                    {
                        documentFile = await _cmnDocumentRepository.AddAsync(documentFile);
                        documentCommandResponse.Message = request.FileName + " Saved Successfully";
                        _logger.LogInformation($"{documentCommandResponse.Message = request.FileName + " is Successfully Created"}");
                    }
                    else
                    {
                        var model = _cmnDocumentRepository.GetDocumentFileInfo(documentFile.FileUniqueName);
                        await _cmnDocumentRepository.DeleteAsync(model);
                        documentCommandResponse.Message = documentFile.FileName + " Removed Successfully";
                    }
                    //  documentCommandResponse.cmnDto = _mapper.Map<CreateOrUpdateCmnDocumentDto>(documentFile);
                }
            }
            catch (Exception ex)
            {

                documentCommandResponse.Success = false;
                documentCommandResponse.Message = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
            }
            return documentCommandResponse;
        }
    }
}
