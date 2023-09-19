using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCourtByFileMasterId
{
    public class GetAllCourtByFileMasterIdQuery : IRequest<List<GetAllCourtByFileMasterIdVm>>
    {
        public int FileMasterId { get; set; }
    }
}
