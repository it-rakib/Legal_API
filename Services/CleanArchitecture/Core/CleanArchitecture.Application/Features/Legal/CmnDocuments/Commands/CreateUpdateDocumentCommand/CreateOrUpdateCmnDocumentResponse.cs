using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands.CreateUpdateDocumentCommand
{
    public class CreateOrUpdateCmnDocumentResponse : BaseResponse
    {
        public CreateOrUpdateCmnDocumentResponse()
        {
        }
        public CreateOrUpdateCmnDocumentDto documentDto { get; set; }
    }
}
