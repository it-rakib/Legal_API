using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMaster
{
    public class GetAllFileMasterQuery : IRequest<List<GetAllFileMasterVm>>
    {
    }
}
