using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitioner
{
    public class GetAllPetitionerQuery : IRequest<List<GetAllPetitionerVm>>
    {
    }
}
