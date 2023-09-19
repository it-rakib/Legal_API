using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Command.CreateUpdateFileType
{
    public class CreateUpdateFileTypeResponse : BaseResponse
    {
        public CreateUpdateFileTypeResponse()
        {
        }
        public CreateUpdateFileTypeDto fileTypeDto { get; set; }
    }
}
