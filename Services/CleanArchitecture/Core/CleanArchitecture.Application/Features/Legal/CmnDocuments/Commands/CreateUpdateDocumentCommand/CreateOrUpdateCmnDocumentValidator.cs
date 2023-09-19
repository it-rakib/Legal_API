using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;

namespace CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands.CreateUpdateDocumentCommand
{
    public class CreateOrUpdateCmnDocumentValidator : AbstractValidator<CreateOrUpdateCmnDocumentCommand>
    {
        private readonly ICmnDocumentRepository _cmnDocumentRepository;

        public CreateOrUpdateCmnDocumentValidator(ICmnDocumentRepository cmnDocumentRepository)
        {
            _cmnDocumentRepository = cmnDocumentRepository ?? throw new ArgumentNullException(nameof(cmnDocumentRepository));
            RuleFor(p => p.FileUniqueName)
                  .NotEmpty().WithMessage("{PropertyName} is required.")
                  .NotNull();
        }
    }
}
