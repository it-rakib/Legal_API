using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Command.CreateUpdateJurisdiction
{
    public class CreateUpdateJurisdictionCommand : IRequest<CreateUpdateJurisdictionResponse>
    {
        public int JurisdictionId { get; set; }
        public string JurisdictionName { get; set; }
    }
}
