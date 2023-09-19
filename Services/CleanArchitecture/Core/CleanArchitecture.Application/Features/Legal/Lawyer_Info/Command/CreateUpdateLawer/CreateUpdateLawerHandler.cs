using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Command.CreateUpdateLawer
{
    public class CreateUpdateLawerHandler : IRequestHandler<CreateUpdateLawerCommand, CreateUpdateLawerResponse>
    {
        private readonly ILawyerInfoRepository _lawyerInfoRepository;
        private readonly ILogger<CreateUpdateLawerHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateLawerHandler(ILawyerInfoRepository lawyerInfoRepository, ILogger<CreateUpdateLawerHandler> logger, IMapper mapper)
        {
            _lawyerInfoRepository = lawyerInfoRepository ?? throw new ArgumentNullException(nameof(lawyerInfoRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateLawerResponse> Handle(CreateUpdateLawerCommand request, CancellationToken cancellationToken)
        {
            var lawyerResponse = new CreateUpdateLawerResponse();
            try
            {
                var validator = new CreateUpdateLawerValidator(_lawyerInfoRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    lawyerResponse.Success = false;
                    lawyerResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        lawyerResponse.Message = lawyerResponse.Message + Environment.NewLine + error.ErrorMessage;
                        lawyerResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(lawyerResponse.Message);
                }

                if (lawyerResponse.Success)
                {
                    var lawyerInfo = new LawyerInfo
                    {
                        LawyerId = request.LawyerId,
                        LawyerName = request.LawyerName.ToUpper(),
                        LawyerAddress = request.LawyerAddress,
                        ContactNo = request.ContactNo,
                        Email = request.Email
                    };
                    if (request.LawyerId == 0)
                    {
                        lawyerInfo = await _lawyerInfoRepository.AddAsync(lawyerInfo);
                        lawyerResponse.Message = lawyerInfo.LawyerName + " Saved Successfully!";
                    }
                    else
                    {
                        var lawyerInfoId = await _lawyerInfoRepository.GetLawyerById(request.LawyerId);
                        if (lawyerInfoId != null)
                        {
                            await _lawyerInfoRepository.Update(lawyerInfo);
                            lawyerResponse.Message = lawyerInfo.LawyerName + " Updated Successfully!";
                        }
                        else
                        {
                            lawyerResponse.Message = "Data Not Found!";
                        }
                    }
                    lawyerResponse.LawerDto = _mapper.Map<CreateUpdateLawerDto>(lawyerInfo);

                }
                _logger.LogInformation(lawyerResponse.Message);
                return lawyerResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
