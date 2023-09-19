using CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiary;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiaryGrid;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IUpdateDiaryRepository : IAsyncLegalRepository<UpdateDiary>
    {
        Task<UpdateDiary> GetDiaryById(int diaryId);
        //Task<bool> IsDiaryExist(DateTime previousDate,string previousDateFor,DateTime nextDate,string nextDateFor);
        Task<List<GetAllUpdateDiaryVm>> GetAllUpdateDiary();
        Task<GridEntity<GetAllUpdateDiaryGridVm>> GetAllDairyGrid(GridOptions options,int fileMasterId);
        Task<bool> IsDiaryExist(string previousDate, string previousDateFor, string nextDate, string nextDateFor);
    }
}
