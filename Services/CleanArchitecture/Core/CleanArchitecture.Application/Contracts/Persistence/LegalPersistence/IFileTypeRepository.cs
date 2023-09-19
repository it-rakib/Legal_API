using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileType;
using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileTypeGrid;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface IFileTypeRepository : IAsyncLegalRepository<FileType>
    {
        Task<FileType> GetFileTypeById(int fileTypeId);
        Task<bool> IsFileTypeExist(int id, string name);
       Task<GridEntity<GetAllFileTypeGridVm>> GetAllFileTypeGrid(GridOptions options);
        Task<List<GetAllFileTypeVm>> GetAllFileType();
    }
}
