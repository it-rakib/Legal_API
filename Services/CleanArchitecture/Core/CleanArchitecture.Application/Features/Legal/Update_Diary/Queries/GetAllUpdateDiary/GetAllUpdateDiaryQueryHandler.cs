using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiary
{
    public class GetAllUpdateDiaryQueryHandler : IRequestHandler<GetAllUpdateDiaryQuery,List<GetAllUpdateDiaryVm>>
    {
        private readonly IUpdateDiaryRepository _updateDiaryRepository;

        public GetAllUpdateDiaryQueryHandler(IUpdateDiaryRepository updateDiaryRepository)
        {
            _updateDiaryRepository = updateDiaryRepository ?? throw new ArgumentNullException(nameof(updateDiaryRepository));
        }

        public async Task<List<GetAllUpdateDiaryVm>> Handle(GetAllUpdateDiaryQuery request, CancellationToken cancellationToken)
        {
            var res = await _updateDiaryRepository.GetAllUpdateDiary();
            return res;
        
        }
    }
}
