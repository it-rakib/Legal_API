using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt
{
    public class CreateUpdateCourtValidator : AbstractValidator<CreateUpdateCourtCommand>
    {
        private readonly ICourtRepository _courtRepository;

        public CreateUpdateCourtValidator(ICourtRepository courtRepository)
        {
            _courtRepository = courtRepository ?? throw new ArgumentNullException(nameof(courtRepository));
            RuleFor(p => p.CourtName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueCourtName)
                .WithMessage("This Court AllReady Added!");
        }

        private async Task<bool> UniqueCourtName(CreateUpdateCourtCommand e, CancellationToken token)
        {
            try
            {
                return !(await _courtRepository.IsCourtNameExist(e.CourtId, e.CourtName));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

    }
}
