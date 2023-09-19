using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Command.CreateUpdatePetitioner
{
    public class CreateUpdatePetitionerHandler : IRequestHandler<CreateUpdatePetitionerCommand, CreateUpdatePetitionerResponse>
    {
        private readonly IPetitionerRepository _petitionerRepository;
        private readonly ILogger<CreateUpdatePetitionerHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdatePetitionerHandler(IPetitionerRepository petitionerRepository, ILogger<CreateUpdatePetitionerHandler> logger, IMapper mapper)
        {
            _petitionerRepository = petitionerRepository ?? throw new ArgumentNullException(nameof(petitionerRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdatePetitionerResponse> Handle(CreateUpdatePetitionerCommand request, CancellationToken cancellationToken)
        {
            var petitionerResponse = new CreateUpdatePetitionerResponse();
            try
            {
                var validator = new CreateUpdatePetitionerValidator(_petitionerRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    petitionerResponse.Success = false;
                    petitionerResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        petitionerResponse.Message = petitionerResponse.Message + Environment.NewLine + error.ErrorMessage;
                        petitionerResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(petitionerResponse.Message);
                }

                if (petitionerResponse.Success)
                {
                    var petionerInfo = new PetitionerInfo
                    {
                        PetitionerId = request.PetitionerId,
                        PetitionerName = request.PetitionerName,
                        PetitionerAddress = request.PetitionerAddress,
                        ContactNo = request.ContactNo,
                        Email = request.Email
                    };
                    if (request.PetitionerId == 0)
                    {
                        petionerInfo = await _petitionerRepository.AddAsync(petionerInfo);
                        petitionerResponse.Message = petionerInfo.PetitionerName + " Saved Successfully!";
                    }
                    else
                    {
                        var petionerInfoId = await _petitionerRepository.GetPetitionById(request.PetitionerId);
                        if (petionerInfoId != null)
                        {
                            await _petitionerRepository.Update(petionerInfo);
                            petitionerResponse.Message = petionerInfo.PetitionerName + " Updated Successfully!";
                        }
                        else
                        {
                            petitionerResponse.Message = "Data Not Found!";
                        }
                    }
                    petitionerResponse.PetitionerDto = _mapper.Map<CreateUpdatePetitionerDto>(petionerInfo);

                }
                _logger.LogInformation(petitionerResponse.Message);
                return petitionerResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
