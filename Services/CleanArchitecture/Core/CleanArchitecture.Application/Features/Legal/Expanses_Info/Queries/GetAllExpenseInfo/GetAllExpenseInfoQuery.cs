using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseInfo
{
    public class GetAllExpenseInfoQuery : IRequest<List<GetAllExpenseInfoVm>>
    {
    }
}
