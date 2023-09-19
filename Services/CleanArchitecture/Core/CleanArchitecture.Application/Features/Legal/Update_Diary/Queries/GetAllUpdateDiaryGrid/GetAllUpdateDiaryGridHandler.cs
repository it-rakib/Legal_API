using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiaryGrid
{
    public class GetAllUpdateDiaryGridHandler : IRequestHandler<GetAllUpdateDiaryGridQuery,GridEntity<GetAllUpdateDiaryGridVm>>
    {
        private readonly IUpdateDiaryRepository _updateDiaryRepository;

        public GetAllUpdateDiaryGridHandler(IUpdateDiaryRepository updateDiaryRepository)
        {
            _updateDiaryRepository = updateDiaryRepository ?? throw new ArgumentNullException(nameof(updateDiaryRepository));
        }

        public async Task<GridEntity<GetAllUpdateDiaryGridVm>> Handle(GetAllUpdateDiaryGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _updateDiaryRepository.GetAllDairyGrid(request.options,request.FileMasterId);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        
        }
    }
}
