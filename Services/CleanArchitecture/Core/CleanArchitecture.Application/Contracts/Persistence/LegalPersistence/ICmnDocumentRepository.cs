using CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Common.Service.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence.LegalPersistence
{
    public interface ICmnDocumentRepository : IAsyncLegalRepository<CmnDocument>
    {

        Task<List<CmnDocument>> GetAllDocumentListAsync();
        Task<GridEntity<CmnDocument>> GetAllDocumentListPagingAsync(GridOptions options);

        CmnDocument GetDocumentFileInfo(string documentFileFileUniqueName);
        void AddRemoveDocument(DocumentVM cmnDocumentFile);
    }
}
