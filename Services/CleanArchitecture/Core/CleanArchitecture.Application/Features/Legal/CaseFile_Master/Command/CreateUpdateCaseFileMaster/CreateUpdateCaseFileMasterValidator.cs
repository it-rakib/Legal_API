using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Command.CreateUpdateCaseFileMaster
{
    public class CreateUpdateCaseFileMasterValidator : AbstractValidator<CreateUpdateCaseFileMasterCommand>
    {
        private readonly ICasefileMasterRepository _casefileMasterRepository;

        public CreateUpdateCaseFileMasterValidator(ICasefileMasterRepository casefileMasterRepository)
        {
            _casefileMasterRepository = casefileMasterRepository ?? throw new ArgumentNullException(nameof(casefileMasterRepository));
            RuleFor(p => p.CaseNo)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueCaseFileName)
                .WithMessage("This Case File AllReady Added!");
        }

        private async Task<bool> UniqueCaseFileName(CreateUpdateCaseFileMasterCommand e, CancellationToken token)
        {
            try
            {
                return !(await _casefileMasterRepository.IsCaseFileExist(e.FileMasterId, e.CaseNo));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
