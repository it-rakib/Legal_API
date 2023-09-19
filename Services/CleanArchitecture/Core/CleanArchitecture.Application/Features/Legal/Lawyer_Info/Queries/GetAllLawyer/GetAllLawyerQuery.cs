using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyer
{
    public class GetAllLawyerQuery : IRequest<List<GetAllLawyerVm>>
    {
    }
}
