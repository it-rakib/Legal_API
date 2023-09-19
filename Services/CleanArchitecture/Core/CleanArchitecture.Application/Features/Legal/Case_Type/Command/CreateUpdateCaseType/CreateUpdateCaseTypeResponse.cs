using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType
{
    public class CreateUpdateCaseTypeResponse : BaseResponse
    {
        public CreateUpdateCaseTypeResponse()
        {
        }
        public CreateUpdateCaseTypeDto caseTypeDto { get; set; }
    }
}
