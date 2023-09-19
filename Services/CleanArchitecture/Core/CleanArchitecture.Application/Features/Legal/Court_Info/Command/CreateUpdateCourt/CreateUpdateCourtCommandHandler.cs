using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt
{
    public class CreateUpdateCourtCommandHandler : IRequestHandler<CreateUpdateCourtCommand,CreateUpdateCourtResponse>
    {
        private readonly ICourtRepository _courtRepository;
        private readonly ILogger<CreateUpdateCourtCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateCourtCommandHandler(ICourtRepository courtRepository, ILogger<CreateUpdateCourtCommandHandler> logger, IMapper mapper)
        {
            _courtRepository = courtRepository ?? throw new ArgumentNullException(nameof(courtRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateCourtResponse> Handle(CreateUpdateCourtCommand request, CancellationToken cancellationToken)
        {
            var courtResponse = new CreateUpdateCourtResponse();

            try
            {
                var validator = new CreateUpdateCourtValidator(_courtRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    courtResponse.Success = false;
                    courtResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        courtResponse.Message = courtResponse.Message + Environment.NewLine + error.ErrorMessage;
                        courtResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(courtResponse.Message);
                }

                if (courtResponse.Success)
                {
                    var courtInfo = new CourtInfo
                    {
                        CourtId = request.CourtId,
                        CourtName = request.CourtName.ToUpper(),
                        CourtNo = request.CourtNo,
                        CourtAddress = request.CourtAddress,
                        Phone = request.Phone,
                        Email = request.Email,
                        Website = request.Website,
                        Fax = request.Fax,
                        DistrictId = request.DistrictId,
                        DistrictWiseJurisdictions = SetDistrictWiseJurisdiction(request.DistrictWiseJurisdictions)
                    };
                    if (request.CourtId == 0)
                    {
                        courtInfo = await _courtRepository.AddAsync(courtInfo);
                        courtResponse.Message = courtInfo.CourtName + " Saved Successfully!";
                    }
                    else
                    {
                        var courtInfoId = await _courtRepository.GetCourtById(request.CourtId);
                        if (courtInfoId != null)
                        {
                            await _courtRepository.UpdateCourtInfo(courtInfo);
                            courtResponse.Message = courtInfo.CourtName + " Updated Successfully!";
                        }
                        else
                        {
                            courtResponse.Message = "Data Not Found!";
                        }
                    }
                    courtResponse.CourtDto = _mapper.Map<CreateUpdateCourtDto>(courtInfo);

                }
                _logger.LogInformation(courtResponse.Message);
                return courtResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public List<DistrictWiseJurisdiction> SetDistrictWiseJurisdiction(ICollection<DistrictWiseJurisdictionCommand> districtWiseJurisdictions)
        {
            try
            {
                List<DistrictWiseJurisdiction> districtWiseJurisdictions1 = new();
                foreach (var dj in districtWiseJurisdictions)
                {
                    DistrictWiseJurisdiction swj = new()
                    {
                        DistrictWiseJurisdictionId = dj.DistrictWiseJurisdictionId,
                        CourtId = dj.CourtId,
                        DistrictId = dj.DistrictId,
                        JurisdictionId = dj.JurisdictionId
                    };
                    districtWiseJurisdictions1.Add(swj);
                }
                return districtWiseJurisdictions1;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }            
        }
    }
}
