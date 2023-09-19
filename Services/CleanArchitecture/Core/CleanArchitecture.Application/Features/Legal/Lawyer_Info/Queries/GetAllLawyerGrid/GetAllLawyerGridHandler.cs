using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyerGrid
{
    public class GetAllLawyerGridHandler : IRequestHandler<GetAllLawyerGridQuery,GridEntity<GetAllLawyerGridVm>>
    {
        private readonly ILawyerInfoRepository _lawyerInfoRepository;

        public GetAllLawyerGridHandler(ILawyerInfoRepository lawyerInfoRepository)
        {
            _lawyerInfoRepository = lawyerInfoRepository ?? throw new ArgumentNullException(nameof(lawyerInfoRepository));
        }

        public async Task<GridEntity<GetAllLawyerGridVm>> Handle(GetAllLawyerGridQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _lawyerInfoRepository.GetAllLawyerGrid(request.options);
                return res;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
    }
}
