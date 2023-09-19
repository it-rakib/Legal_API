using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType
{
    public class GetAllCaseTypeQuery : IRequest<List<GetAllCaseTypeVm>>
    {
    }
}
