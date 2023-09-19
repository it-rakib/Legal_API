using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Status_Info.Queries.GetAllStatus
{
    public class GetAllStatusQuery : IRequest<List<GetAllStatusVm>>
    {
    }
}
