using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Command.CreateUpdateMatter
{
    public class CreateUpdateMatterResponse : BaseResponse
    {
        public CreateUpdateMatterResponse()
        {
        }
        public CreateUpdateMatterDto matterDto { get; set; }
    }
}
