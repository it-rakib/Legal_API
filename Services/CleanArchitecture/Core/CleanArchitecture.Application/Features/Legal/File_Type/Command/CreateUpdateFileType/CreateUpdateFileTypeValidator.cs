using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Command.CreateUpdateFileType
{
    public class CreateUpdateFileTypeValidator : AbstractValidator<CreateUpdateFileTypeCommand>
    {
        private readonly IFileTypeRepository _fileTypeRepository;

        public CreateUpdateFileTypeValidator(IFileTypeRepository fileTypeRepository)
        {
            _fileTypeRepository = fileTypeRepository ?? throw new ArgumentNullException(nameof(fileTypeRepository));

            RuleFor(p => p.FileTypeName)
                  .NotEmpty().WithMessage("{PropertyName} is required!")
                  .NotNull();
            RuleFor(b => b)
                .MustAsync(UniqueFileTypeName)
                .WithMessage("This FileType AllReady Added!");
        }

        private async Task<bool> UniqueFileTypeName(CreateUpdateFileTypeCommand e, CancellationToken token)
        {
            try
            {
                return !(await _fileTypeRepository.IsFileTypeExist(e.FileTypeId, e.FileTypeName));
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
