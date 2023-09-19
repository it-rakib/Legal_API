using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyer
{
    public class GetAllLawyerQueryHandler : IRequestHandler<GetAllLawyerQuery,List<GetAllLawyerVm>>
    {
        private readonly ILawyerInfoRepository _lawyerInfoRepository;

        public GetAllLawyerQueryHandler(ILawyerInfoRepository lawyerInfoRepository)
        {
            _lawyerInfoRepository = lawyerInfoRepository ?? throw new ArgumentNullException(nameof(lawyerInfoRepository));
        }

        public async Task<List<GetAllLawyerVm>> Handle(GetAllLawyerQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _lawyerInfoRepository.GetAllLawyer();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }        }
    }
}
