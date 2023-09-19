using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Command.CreateUpdateDiary
{
    public class CreateUpdateDiaryHandler : IRequestHandler<CreateUpdateDiaryCommand,CreateUpdateDiaryResponse>
    {
        private readonly IUpdateDiaryRepository _updateDiaryRepository;
        private readonly ILogger<CreateUpdateDiaryHandler> _logger;
        private readonly IMapper _mapper;

        public CreateUpdateDiaryHandler(IUpdateDiaryRepository updateDiaryRepository, ILogger<CreateUpdateDiaryHandler> logger, IMapper mapper)
        {
            _updateDiaryRepository = updateDiaryRepository ?? throw new ArgumentNullException(nameof(updateDiaryRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateUpdateDiaryResponse> Handle(CreateUpdateDiaryCommand request, CancellationToken cancellationToken)
        {
            var diaryResponse = new CreateUpdateDiaryResponse();
            try
            {
                var validator = new CreateUpdateDiaryValidator(_updateDiaryRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Count > 0)
                {
                    diaryResponse.Success = false;
                    diaryResponse.ValidationErrors = new List<string>();
                    foreach (var error in validationResult.Errors)
                    {
                        diaryResponse.Message = diaryResponse.Message + Environment.NewLine + error.ErrorMessage;
                        diaryResponse.ValidationErrors.Add(error.ErrorMessage);
                    }
                    _logger.LogError(diaryResponse.Message);
                }


                if (diaryResponse.Success)
                {
                    var dairyUpdate = new UpdateDiary()
                    {
                       DiaryId = request.DiaryId,
                       FileMasterId = request.FileMasterId,
                       PreviousDate = DateTime.Parse(request.PreviousDate),
                       PreviousDateFor = request.PreviousDateFor,
                       NextDate = request.NextDate == "" ? null : DateTime.Parse(request.NextDate),
                       NextDateFor = request.NextDateFor,
                       StatusId = request.StatusId,
                       StatusDate = request.StatusDate == "" ? null : DateTime.Parse(request.StatusDate)

                    };
                    if (request.DiaryId == 0)
                    {
                        dairyUpdate.CreatedBy = request.CreatedBy;
                        dairyUpdate.CreatedAt = DateTime.Now;

                        dairyUpdate = await _updateDiaryRepository.AddAsync(dairyUpdate);
                        diaryResponse.Message = "Diary Saved Successfully!";
                    }
                    else
                    {
                        var dairyUpdateId = await _updateDiaryRepository.GetDiaryById(request.DiaryId);
                        if (dairyUpdateId != null)
                        {
                            dairyUpdate.CreatedBy = dairyUpdateId.CreatedBy;
                            dairyUpdate.CreatedAt = dairyUpdateId.CreatedAt;
                            dairyUpdate.UpdatedAt = DateTime.Now;
                            dairyUpdate.UpdatedBy = request.UpdatedBy;
                            await _updateDiaryRepository.UpdateAsync(dairyUpdate);
                            diaryResponse.Message =" Diary Updated Successfully!";
                        }
                        else
                        {
                            diaryResponse.Message = "Data Not Found!";
                        }
                    }
                    diaryResponse.diaryDto = _mapper.Map<CreateUpdateDiaryDto>(dairyUpdate);

                }
                _logger.LogInformation(diaryResponse.Message);
                return diaryResponse;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
