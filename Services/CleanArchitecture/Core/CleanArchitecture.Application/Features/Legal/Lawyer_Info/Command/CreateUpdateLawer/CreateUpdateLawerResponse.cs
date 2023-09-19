using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Command.CreateUpdateLawer
{
    public class CreateUpdateLawerResponse : BaseResponse
    {
        public CreateUpdateLawerResponse()
        {
        }
        public CreateUpdateLawerDto LawerDto { get; set; }
    }
}
