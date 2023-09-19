using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.OnBehalfOfInfo.Queries.GetAllOnBehalfOf
{
    public class GetAllOnBehalfOfQuery : IRequest<List<GetAllOnBehalfOfVm>>
    { 
    }
}
