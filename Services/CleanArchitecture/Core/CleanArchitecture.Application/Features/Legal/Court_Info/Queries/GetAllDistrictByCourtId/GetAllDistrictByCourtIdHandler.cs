using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllDistrictByCourtId
{
    public class GetAllDistrictByCourtIdHandler : IRequestHandler<GetAllDistrictByCourtIdQuery,List<GetAllDistrictByCourtIdVm>>
    {
        private readonly ICourtRepository _courtRepository;

        public GetAllDistrictByCourtIdHandler(ICourtRepository courtRepository)
        {
            _courtRepository = courtRepository ?? throw new ArgumentNullException(nameof(courtRepository));
        }

        public async Task<List<GetAllDistrictByCourtIdVm>> Handle(GetAllDistrictByCourtIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _courtRepository.GetAllDistrictByCourtId(request.CourtId);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
