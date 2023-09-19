using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetAllCompany
{
    public class GetAllCompanyQuery : IRequest<List<GetAllCompanyVm>>
    {
    }
}
