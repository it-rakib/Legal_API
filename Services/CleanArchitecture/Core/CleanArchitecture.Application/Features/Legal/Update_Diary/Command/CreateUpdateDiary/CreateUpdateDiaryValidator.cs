using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Command.CreateUpdateDiary
{
    public class CreateUpdateDiaryValidator : AbstractValidator<CreateUpdateDiaryCommand>
    {
        private readonly IUpdateDiaryRepository _updateDairyRepository;

        public CreateUpdateDiaryValidator(IUpdateDiaryRepository updateDairyRepository)
        {
            _updateDairyRepository = updateDairyRepository ?? throw new ArgumentNullException(nameof(updateDairyRepository));

            RuleFor(b => b)
                .MustAsync(UniqueDiary)
                .WithMessage("This Diary AllReady Added!");
        }

        private async Task<bool> UniqueDiary(CreateUpdateDiaryCommand e, CancellationToken token)
        {
            try
            {
                return !(await _updateDairyRepository.IsDiaryExist(e.PreviousDate,e.PreviousDateFor,e.NextDate,e.NextDateFor));

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
