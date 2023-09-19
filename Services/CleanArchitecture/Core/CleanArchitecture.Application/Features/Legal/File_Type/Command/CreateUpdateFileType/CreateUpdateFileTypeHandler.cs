using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Command.CreateUpdateFileType
{
    public class CreateUpdateFileTypeHandler : IRequestHandler<CreateUpdateFileTypeCommand, CreateUpdateFileTypeResponse>
    {
        private readonly IFileTypeRepository _fileTypeRepository;
        private readonly ILogger<CreateUpdateFileTypeHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateFileTypeHandler(IFileTypeRepository fileTypeRepository, ILogger<CreateUpdateFileTypeHandler> logger, IMapper mapper)
        {
            _fileTypeRepository = fileTypeRepository ?? throw new ArgumentNullException(nameof(fileTypeRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateFileTypeResponse> Handle(CreateUpdateFileTypeCommand request, CancellationToken cancellationToken)
        {
            var fileTypeResponse = new CreateUpdateFileTypeResponse();
            try
            {
                var validator = new CreateUpdateFileTypeValidator(_fileTypeRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    fileTypeResponse.Success = false;
                    fileTypeResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        fileTypeResponse.Message = fileTypeResponse.Message + Environment.NewLine + error.ErrorMessage;
                        fileTypeResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(fileTypeResponse.Message);
                }

                if (fileTypeResponse.Success)
                {
                    var fileType = new FileType
                    {
                        FileTypeId = request.FileTypeId,
                        FileTypeName = request.FileTypeName.ToUpper(),
                        FileTypeNo = request.FileTypeNo
                    };
                    if (request.FileTypeId == 0)
                    {
                        fileType = await _fileTypeRepository.AddAsync(fileType);
                        fileTypeResponse.Message = fileType.FileTypeName + " Saved Successfully!";
                    }
                    else
                    {
                        var fileTypeId = await _fileTypeRepository.GetFileTypeById(request.FileTypeId);
                        if (fileTypeId != null)
                        {
                            await _fileTypeRepository.Update(fileType);
                            fileTypeResponse.Message = fileType.FileTypeName + " Updated Successfully!";
                        }
                        else
                        {
                            fileTypeResponse.Message = "Data Not Found!";
                        }
                    }
                    fileTypeResponse.fileTypeDto = _mapper.Map<CreateUpdateFileTypeDto>(fileType);

                }
                _logger.LogInformation(fileTypeResponse.Message);
                return fileTypeResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
