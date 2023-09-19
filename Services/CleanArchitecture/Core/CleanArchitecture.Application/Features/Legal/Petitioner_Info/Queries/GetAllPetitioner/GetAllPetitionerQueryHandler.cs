using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitioner
{
    public class GetAllPetitionerQueryHandler : IRequestHandler<GetAllPetitionerQuery,List<GetAllPetitionerVm>>
    {
        private readonly IPetitionerRepository _petitionerRepository;

        public GetAllPetitionerQueryHandler(IPetitionerRepository petitionerRepository)
        {
            _petitionerRepository = petitionerRepository ?? throw new ArgumentNullException(nameof(petitionerRepository));
        }

        public async Task<List<GetAllPetitionerVm>> Handle(GetAllPetitionerQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _petitionerRepository.GetAllPetitioner();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
