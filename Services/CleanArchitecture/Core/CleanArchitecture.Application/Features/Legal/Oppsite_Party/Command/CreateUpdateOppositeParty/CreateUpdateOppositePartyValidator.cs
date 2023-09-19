using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Command.CreateUpdateOppositeParty
{
    public class CreateUpdateOppositePartyValidator : AbstractValidator<CreateUpdateOppositePartyCommand>
    {
        private readonly IOppositePartyRepository _oppositePartyRepository;

        public CreateUpdateOppositePartyValidator(IOppositePartyRepository oppositePartyRepository)
        {
            _oppositePartyRepository = oppositePartyRepository ?? throw new ArgumentNullException(nameof(oppositePartyRepository));
            RuleFor(p => p.PartyName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniquePartyName)
                .WithMessage("This Party AllReady Added!");
        }

        private async Task<bool> UniquePartyName(CreateUpdateOppositePartyCommand e, CancellationToken token)
        {
            try
            {
                return !(await _oppositePartyRepository.IsPartyUnique(e.PartyId, e.PartyName));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
