using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterInfo
{
    public class GetAllMatterQuery : IRequest<List<GetAllMatterVm>>
    {
    }
}
