using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Command.CreateUpdateMatter
{
    public class CreateUpdateMatterHandler : IRequestHandler<CreateUpdateMatterCommand,CreateUpdateMatterResponse>
    {
        private readonly IMatterRepository _matterRepository;
        private readonly ILogger<CreateUpdateMatterHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateMatterHandler(IMatterRepository matterRepository, ILogger<CreateUpdateMatterHandler> logger, IMapper mapper)
        {
            _matterRepository = matterRepository ?? throw new ArgumentNullException(nameof(matterRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateMatterResponse> Handle(CreateUpdateMatterCommand request, CancellationToken cancellationToken)
        {
            var matterResponse = new CreateUpdateMatterResponse();

            try
            {
                var validator = new CreateUpdateMatterValidator(_matterRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    matterResponse.Success = false;
                    matterResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        matterResponse.Message = matterResponse.Message + Environment.NewLine + error.ErrorMessage;
                        matterResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(matterResponse.Message);
                }


                if (matterResponse.Success)
                {
                    var matterInfo = new MatterInfo
                    {
                        MatterId = request.MatterId,
                        MatterName = request.MatterName.ToUpper(),
                        Discription = request.Discription
                    };
                    if (request.MatterId == 0)
                    {
                        matterInfo = await _matterRepository.AddAsync(matterInfo);
                        matterResponse.Message = matterInfo.MatterName + " Saved Successfully!";
                    }
                    else
                    {
                        var matterInfoId = await _matterRepository.GetMatterById(request.MatterId);
                        if (matterInfoId != null)
                        {
                            await _matterRepository.Update(matterInfo);
                            matterResponse.Message = matterInfo.MatterName + " Updated Successfully!";
                        }
                        else
                        {
                            matterResponse.Message = "Data Not Found!";
                        }
                    }
                    matterResponse.matterDto = _mapper.Map<CreateUpdateMatterDto>(matterInfo);

                }
                _logger.LogInformation(matterResponse.Message);
                return matterResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
