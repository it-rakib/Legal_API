using MediatR;

namespace CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands.CreateUpdateDocumentCommand
{
    public class CreateOrUpdateCmnDocumentCommand : IRequest<CreateOrUpdateCmnDocumentResponse>
    {
        public string FileName { get; set; }
        public string ModuleName { get; set; }
        public int ModuleMasterId { get; set; }
        public int? FileSize { get; set; }
        public string FileExtension { get; set; }
        public string FileUniqueName { get; set; }
        public string ActionType { get; set; }
    }
}
