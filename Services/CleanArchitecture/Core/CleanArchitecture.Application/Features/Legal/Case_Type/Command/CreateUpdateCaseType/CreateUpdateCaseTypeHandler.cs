using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType
{
    public class CreateUpdateCaseTypeHandler : IRequestHandler<CreateUpdateCaseTypeCommand, CreateUpdateCaseTypeResponse>
    {
        private readonly ICaseTypeRepository _caseTypeRepository;
        private readonly ILogger<CreateUpdateCaseTypeHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateCaseTypeHandler(ICaseTypeRepository caseTypeRepository, ILogger<CreateUpdateCaseTypeHandler> logger, IMapper mapper)
        {
            _caseTypeRepository = caseTypeRepository ?? throw new ArgumentNullException(nameof(caseTypeRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateCaseTypeResponse> Handle(CreateUpdateCaseTypeCommand request, CancellationToken cancellationToken)
        {
            var caseTypeResponse = new CreateUpdateCaseTypeResponse();
            try
            {
                var validator = new CreateUpdateCaseTypeValidator(_caseTypeRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    caseTypeResponse.Success = false;
                    caseTypeResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        caseTypeResponse.Message = caseTypeResponse.Message + Environment.NewLine + error.ErrorMessage;
                        caseTypeResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(caseTypeResponse.Message);
                }

                if (caseTypeResponse.Success)
                {
                    var caseType = new CaseType
                    {
                       CaseTypeId = request.CaseTypeId,
                       CaseTypeName = request.CaseTypeName.ToUpper()
                    };
                    if (request.CaseTypeId == 0)
                    {
                        caseType = await _caseTypeRepository.AddAsync(caseType);
                        caseTypeResponse.Message = caseType.CaseTypeName + " Saved Successfully!";
                    }
                    else
                    {
                        var caseTypeId = await _caseTypeRepository.GetCaseTypeById(request.CaseTypeId);
                        if (caseTypeId != null)
                        {
                            await _caseTypeRepository.Update(caseType);
                            caseTypeResponse.Message = caseType.CaseTypeName + " Updated Successfully!";
                        }
                        else
                        {
                            caseTypeResponse.Message = "Data Not Found!";
                        }
                    }
                    caseTypeResponse.caseTypeDto = _mapper.Map<CreateUpdateCaseTypeDto>(caseType);

                }
                _logger.LogInformation(caseTypeResponse.Message);
                return caseTypeResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }
    }
}
