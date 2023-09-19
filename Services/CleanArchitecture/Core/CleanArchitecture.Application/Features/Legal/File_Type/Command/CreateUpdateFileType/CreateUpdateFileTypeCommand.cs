using MediatR;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Command.CreateUpdateFileType
{
    public class CreateUpdateFileTypeCommand : IRequest<CreateUpdateFileTypeResponse>
    {
        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string FileTypeNo { get; set; }
    }
}
