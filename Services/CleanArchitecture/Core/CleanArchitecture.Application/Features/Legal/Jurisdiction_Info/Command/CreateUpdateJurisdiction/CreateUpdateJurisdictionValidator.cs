using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Command.CreateUpdateJurisdiction
{
    public class CreateUpdateJurisdictionValidator : AbstractValidator<CreateUpdateJurisdictionCommand>
    {
        private readonly IJurisdictionRepository _jurisdictionRepository;

        public CreateUpdateJurisdictionValidator(IJurisdictionRepository jurisdictionRepository)
        {
            _jurisdictionRepository = jurisdictionRepository ?? throw new ArgumentNullException(nameof(jurisdictionRepository));
            RuleFor(p => p.JurisdictionName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueJurisdictionName)
                .WithMessage("This Jurisdiction AllReady Added!");
        }

        private async Task<bool> UniqueJurisdictionName(CreateUpdateJurisdictionCommand e, CancellationToken token)
        {
            try
            {
                return !(await _jurisdictionRepository.IsJurisdictionNameExist(e.JurisdictionId, e.JurisdictionName));

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        
        }
    }
}
