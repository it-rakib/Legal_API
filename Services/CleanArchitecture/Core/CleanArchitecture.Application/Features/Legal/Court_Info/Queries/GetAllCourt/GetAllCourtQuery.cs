using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt
{
    public class GetAllCourtQuery : IRequest<List<GetAllCourtVm>>
    {
    }
}
