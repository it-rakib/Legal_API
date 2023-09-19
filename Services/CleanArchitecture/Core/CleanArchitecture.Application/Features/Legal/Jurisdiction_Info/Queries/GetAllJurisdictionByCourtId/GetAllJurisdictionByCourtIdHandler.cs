using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionByCourtId
{
    public class GetAllJurisdictionByCourtIdHandler : IRequestHandler<GetAllJurisdictionByCourtIdQuery,List<GetAllJurisdictionByCourtIdVm>>
    {
        private readonly IJurisdictionRepository _jurisdictionRepository;

        public GetAllJurisdictionByCourtIdHandler(IJurisdictionRepository jurisdictionRepository)
        {
            _jurisdictionRepository = jurisdictionRepository ?? throw new ArgumentNullException(nameof(jurisdictionRepository));
        }

        public async Task<List<GetAllJurisdictionByCourtIdVm>> Handle(GetAllJurisdictionByCourtIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _jurisdictionRepository.GetAllJurisdictionByCourtId(request.CourtId);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
