using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo
{
    public class GetAllFileMasterByRegNoQuery : IRequest<List<GetAllFileMasterByRegNoVm>>
    {
        public string Search { get; set; }
    }
}
