using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands;
using CleanArchitecture.Domain.LegalModel;
using Common.Service.CommonEntities.KendoGrid;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Legal
{
    public class CmnDocumentRepository : LegalBaseRepository<CmnDocument>, ICmnDocumentRepository
    {
        public CmnDocumentRepository(LEGALDBContext dbContext) : base(dbContext)
        {
        }

        public void AddRemoveDocument(DocumentVM cmnDocumentFile)
        {
            var documentFile = new CmnDocument()
            {
                DocumentId = cmnDocumentFile.DocumentId,
                FileName = cmnDocumentFile.FileName,
                ModuleName = cmnDocumentFile.ModuleName,
                ModuleMasterId = cmnDocumentFile.ModuleMasterId,
                FileSize = cmnDocumentFile.FileSize,
                FileExtension = cmnDocumentFile.FileExtension,
                FileUniqueName = cmnDocumentFile.FileUniqueName
            };
            if (cmnDocumentFile.ActionType == "Save")
            {
                // _documentRepository.AddAsync(documentFile);
                _dbContext.Add(documentFile);
                _dbContext.SaveChanges();

            }
            if (cmnDocumentFile.ActionType == "Remove")
            {
                var model = GetDocumentFileInfo(documentFile.FileUniqueName);
                //_documentRepository.DeleteAsync(model);
                _dbContext.Entry(model).State = EntityState.Deleted;
                _dbContext.SaveChanges();

            }
        }

        public Task<List<CmnDocument>> GetAllDocumentListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<GridEntity<CmnDocument>> GetAllDocumentListPagingAsync(GridOptions options)
        {
            throw new System.NotImplementedException();
        }

        public CmnDocument GetDocumentFileInfo(string documentFileFileUniqueName)
        {
            return _dbContext.CmnDocuments
                .FirstOrDefault(d => d.FileUniqueName == documentFileFileUniqueName);
        }
    }
}
