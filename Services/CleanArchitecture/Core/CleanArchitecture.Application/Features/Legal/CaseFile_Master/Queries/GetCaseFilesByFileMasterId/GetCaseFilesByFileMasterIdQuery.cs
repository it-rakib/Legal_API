using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetCaseFilesByFileMasterId
{
    public class GetCaseFilesByFileMasterIdQuery : IRequest<List<GetCaseFilesByFileMasterIdVm>>
    {
        public int FileMasterId { get; set; }
    }
}
