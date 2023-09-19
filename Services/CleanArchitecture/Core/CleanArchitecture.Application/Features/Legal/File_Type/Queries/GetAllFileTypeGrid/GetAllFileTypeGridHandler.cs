using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileTypeGrid
{
    public class GetAllFileTypeGridHandler : IRequestHandler<GetAllFileTypeGridQuery, GridEntity<GetAllFileTypeGridVm>>
    {
        private readonly IFileTypeRepository _fileTypeRepository;

        public GetAllFileTypeGridHandler(IFileTypeRepository fileTypeRepository)
        {
            _fileTypeRepository = fileTypeRepository ?? throw new ArgumentNullException(nameof(fileTypeRepository));
        }

        public async Task<GridEntity<GetAllFileTypeGridVm>> Handle(GetAllFileTypeGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _fileTypeRepository.GetAllFileTypeGrid(request.options);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;

            }
        }
    }
}
