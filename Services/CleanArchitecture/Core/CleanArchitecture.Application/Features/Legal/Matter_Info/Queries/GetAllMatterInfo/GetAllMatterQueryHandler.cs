using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterInfo
{
    public class GetAllMatterQueryHandler : IRequestHandler<GetAllMatterQuery,List<GetAllMatterVm>>
    {
        private readonly IMatterRepository _matterRepository;

        public GetAllMatterQueryHandler(IMatterRepository matterRepository)
        {
            _matterRepository = matterRepository ?? throw new ArgumentNullException(nameof(matterRepository));
        }

        public async Task<List<GetAllMatterVm>> Handle(GetAllMatterQuery request, CancellationToken cancellationToken)
        {
            return await _matterRepository.GetAllMAtter();
        }
    }
}
