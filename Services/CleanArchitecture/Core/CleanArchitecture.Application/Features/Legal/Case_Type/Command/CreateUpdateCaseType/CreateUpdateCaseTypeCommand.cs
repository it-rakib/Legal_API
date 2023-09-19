using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType
{
    public class CreateUpdateCaseTypeCommand : IRequest<CreateUpdateCaseTypeResponse>
    {
        public int CaseTypeId { get; set; }
        public string CaseTypeName { get; set; }
    }
}
