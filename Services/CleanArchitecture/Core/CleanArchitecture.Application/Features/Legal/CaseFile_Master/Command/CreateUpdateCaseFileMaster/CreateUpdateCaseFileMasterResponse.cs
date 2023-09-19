using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Command.CreateUpdateCaseFileMaster
{
    public class CreateUpdateCaseFileMasterResponse : BaseResponse
    {
        public CreateUpdateCaseFileMasterResponse()
        {
        }
        public CreateUpdateCaseFileMasterDto masterDto { get; set; }
    }
}
