using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitionerGrid
{
    public class GetAllPetitionerGridHandler : IRequestHandler<GetAllPetitionerGridQuery,GridEntity<GetAllPetitionerGridVm>>
    {
        private readonly IPetitionerRepository _petitionerRepository;

        public GetAllPetitionerGridHandler(IPetitionerRepository petitionerRepository)
        {
            _petitionerRepository = petitionerRepository ?? throw new ArgumentNullException(nameof(petitionerRepository));
        }

        public async Task<GridEntity<GetAllPetitionerGridVm>> Handle(GetAllPetitionerGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _petitionerRepository.GetAllPetitionerGrid(request.options);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
