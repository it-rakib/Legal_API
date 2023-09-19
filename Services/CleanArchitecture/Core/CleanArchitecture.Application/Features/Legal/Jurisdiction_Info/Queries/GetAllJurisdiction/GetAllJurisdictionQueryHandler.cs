using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdiction
{
    public class GetAllJurisdictionQueryHandler : IRequestHandler<GetAllJurisdictionQuery,List<GetAllJurisdictionVm>>
    {
        private readonly IJurisdictionRepository _jurisdictionRepository;

        public GetAllJurisdictionQueryHandler(IJurisdictionRepository jurisdictionRepository)
        {
            _jurisdictionRepository = jurisdictionRepository ?? throw new ArgumentNullException(nameof(jurisdictionRepository));
        }

        public async Task<List<GetAllJurisdictionVm>> Handle(GetAllJurisdictionQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _jurisdictionRepository.GetAllJurisdiction();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
