using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Command.CreateUpdateLawer
{
    public class CreateUpdateLawerValidator : AbstractValidator<CreateUpdateLawerCommand>
    {
        private readonly ILawyerInfoRepository _lawyerInfoRepository;

        public CreateUpdateLawerValidator(ILawyerInfoRepository lawyerInfoRepository)
        {
            _lawyerInfoRepository = lawyerInfoRepository ?? throw new ArgumentNullException(nameof(lawyerInfoRepository));
            RuleFor(p => p.LawyerName)
                 .NotEmpty().WithMessage("{PropertyName} is required!")
                 .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueLawyerName)
                .WithMessage("This Lawyer AllReady Added!");
        }

        private async Task<bool> UniqueLawyerName(CreateUpdateLawerCommand e, CancellationToken token)
        {
            try
            {
                return !(await _lawyerInfoRepository.IsLawyerNameExist(e.LawyerId, e.LawyerName));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
