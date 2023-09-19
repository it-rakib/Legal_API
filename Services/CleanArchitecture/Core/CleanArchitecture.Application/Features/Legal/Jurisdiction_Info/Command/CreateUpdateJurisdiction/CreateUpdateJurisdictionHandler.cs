using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Command.CreateUpdateJurisdiction
{
    public class CreateUpdateJurisdictionHandler : IRequestHandler<CreateUpdateJurisdictionCommand, CreateUpdateJurisdictionResponse>
    {
        private readonly IJurisdictionRepository _jurisdictionRepository;
        private readonly ILogger<CreateUpdateJurisdictionHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateJurisdictionHandler(IJurisdictionRepository jurisdictionRepository, ILogger<CreateUpdateJurisdictionHandler> logger, IMapper mapper)
        {
            _jurisdictionRepository = jurisdictionRepository ?? throw new ArgumentNullException(nameof(jurisdictionRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateJurisdictionResponse> Handle(CreateUpdateJurisdictionCommand request, CancellationToken cancellationToken)
        {
            var jurisdictionResponse = new CreateUpdateJurisdictionResponse();
            try
            {
                var validator = new CreateUpdateJurisdictionValidator(_jurisdictionRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    jurisdictionResponse.Success = false;
                    jurisdictionResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        jurisdictionResponse.Message = jurisdictionResponse.Message + Environment.NewLine + error.ErrorMessage;
                        jurisdictionResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(jurisdictionResponse.Message);
                }

                if (jurisdictionResponse.Success)
                {
                    var jurisdictionInfo = new JurisdictionInfo
                    {
                        JurisdictionId = request.JurisdictionId,
                        JurisdictionName = request.JurisdictionName.ToUpper()
                    };
                    if (request.JurisdictionId == 0)
                    {
                        jurisdictionInfo = await _jurisdictionRepository.AddAsync(jurisdictionInfo);
                        jurisdictionResponse.Message = jurisdictionInfo.JurisdictionName + " Saved Successfully!";
                    }
                    else
                    {
                        var jurisdictionInfoId = await _jurisdictionRepository.GetJurisdictionById(request.JurisdictionId);
                        if (jurisdictionInfoId != null)
                        {
                            await _jurisdictionRepository.Update(jurisdictionInfo);
                            jurisdictionResponse.Message = jurisdictionInfo.JurisdictionName + " Updated Successfully!";
                        }
                        else
                        {
                            jurisdictionResponse.Message = "Data Not Found!";
                        }
                    }
                    jurisdictionResponse.jurisdictionDto = _mapper.Map<CreateUpdateJurisdictionDto>(jurisdictionInfo);

                }
                _logger.LogInformation(jurisdictionResponse.Message);
                return jurisdictionResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
