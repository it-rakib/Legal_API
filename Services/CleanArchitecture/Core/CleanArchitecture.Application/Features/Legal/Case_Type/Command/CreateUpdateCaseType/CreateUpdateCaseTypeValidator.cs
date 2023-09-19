using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType
{
    public class CreateUpdateCaseTypeValidator : AbstractValidator<CreateUpdateCaseTypeCommand>
    {
        private readonly ICaseTypeRepository _caseTypeRepository;

        public CreateUpdateCaseTypeValidator(ICaseTypeRepository caseTypeRepository)
        {
            _caseTypeRepository = caseTypeRepository ?? throw new ArgumentNullException(nameof(caseTypeRepository));
            RuleFor(p => p.CaseTypeName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueCaseTypeName)
                .WithMessage("This CaseType AllReady Added!");
        }

        private async Task<bool> UniqueCaseTypeName(CreateUpdateCaseTypeCommand e, CancellationToken token)
        {
            try
            {
                return !(await _caseTypeRepository.IsCaseTypeExist(e.CaseTypeId, e.CaseTypeName));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
