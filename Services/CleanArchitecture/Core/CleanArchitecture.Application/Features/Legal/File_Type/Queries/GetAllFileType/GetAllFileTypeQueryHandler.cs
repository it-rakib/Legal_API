using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileType
{
    public class GetAllFileTypeQueryHandler : IRequestHandler<GetAllFileTypeQuery,List<GetAllFileTypeVm>>
    {
        private readonly IFileTypeRepository _fileTypeRepository;

        public GetAllFileTypeQueryHandler(IFileTypeRepository fileTypeRepository)
        {
            _fileTypeRepository = fileTypeRepository ?? throw new ArgumentNullException(nameof(fileTypeRepository));
        }
        public async Task<List<GetAllFileTypeVm>> Handle(GetAllFileTypeQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _fileTypeRepository.GetAllFileType();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        }
    }
}
