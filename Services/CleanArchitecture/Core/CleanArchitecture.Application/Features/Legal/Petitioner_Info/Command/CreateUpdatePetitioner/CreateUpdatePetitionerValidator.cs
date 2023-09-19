using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Command.CreateUpdatePetitioner
{
    public class CreateUpdatePetitionerValidator : AbstractValidator<CreateUpdatePetitionerCommand>
    {
        private readonly IPetitionerRepository _petitionerRepository;

        public CreateUpdatePetitionerValidator(IPetitionerRepository petitionerRepository)
        {
            _petitionerRepository = petitionerRepository ?? throw new ArgumentNullException(nameof(petitionerRepository));
            RuleFor(p => p.PetitionerName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniquePetitioner)
                .WithMessage("This Petitioner AllReady Added!");
        }

        private async Task<bool> UniquePetitioner(CreateUpdatePetitionerCommand e, CancellationToken token)
        {
            try
            {
                return !(await _petitionerRepository.IsPetitionNameExist(e.PetitionerId, e.PetitionerName));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
