using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdiction
{
    public class GetAllJurisdictionQuery : IRequest<List<GetAllJurisdictionVm>>
    {
    }
}
