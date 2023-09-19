using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Command.CreateUpdateMatter
{
    public class CreateUpdateMatterValidator : AbstractValidator<CreateUpdateMatterCommand>
    {
        private readonly IMatterRepository _matterRepository;

        public CreateUpdateMatterValidator(IMatterRepository matterRepository)
        {
            _matterRepository = matterRepository ?? throw new ArgumentNullException(nameof(matterRepository));
            RuleFor(p => p.MatterName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueMatterName)
                .WithMessage("This Matter AllReady Added!");
        }

        private async Task<bool> UniqueMatterName(CreateUpdateMatterCommand e, CancellationToken token)
        {
            try
            {
                return !(await _matterRepository.IsMatterExist(e.MatterId, e.MatterName));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
