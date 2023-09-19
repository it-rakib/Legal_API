using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Command.CreateUpdateOppositeParty
{
    public class CreateUpdateOppositePartyHandler : IRequestHandler<CreateUpdateOppositePartyCommand,CreateUpdateOppositePartyResponse>
    {
        private readonly IOppositePartyRepository _oppositePartyRepository;
        private readonly ILogger<OppositeParty> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateOppositePartyHandler(IOppositePartyRepository oppositePartyRepository, ILogger<OppositeParty> logger, IMapper mapper)
        {
            _oppositePartyRepository = oppositePartyRepository ?? throw new ArgumentNullException(nameof(oppositePartyRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateOppositePartyResponse> Handle(CreateUpdateOppositePartyCommand request, CancellationToken cancellationToken)
        {
            var partyResponse = new CreateUpdateOppositePartyResponse();
            
            try
            {
                var validator = new CreateUpdateOppositePartyValidator(_oppositePartyRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    partyResponse.Success = false;
                    partyResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        partyResponse.Message = partyResponse.Message + Environment.NewLine + error.ErrorMessage;
                        partyResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(partyResponse.Message);
                }

                if (partyResponse.Success)
                {
                    var oppositeParty = new OppositeParty()
                    {
                        PartyId = request.PartyId,
                        PartyName = request.PartyName,
                        PartyAddress = request.PartyAddress,
                        ContactNo = request.ContactNo,
                        Email = request.Email
                    };
                    if (request.PartyId == 0)
                    {
                        oppositeParty = await _oppositePartyRepository.AddAsync(oppositeParty);
                        partyResponse.Message = oppositeParty.PartyName + " Saved Successfully!";
                    }
                    else
                    {
                        var oppositePartyId = await _oppositePartyRepository.GetOppositePrtyById(request.PartyId);
                        if (oppositePartyId != null)
                        {
                            await _oppositePartyRepository.Update(oppositeParty);
                            partyResponse.Message = oppositeParty.PartyName + " Updated Successfully!";
                        }
                        else
                        {
                            partyResponse.Message = "Data Not Found!";
                        }
                    }
                    partyResponse.partyDto = _mapper.Map<CreateUpdateOppositePartyDto>(oppositeParty);

                }
                _logger.LogInformation(partyResponse.Message);
                return partyResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
