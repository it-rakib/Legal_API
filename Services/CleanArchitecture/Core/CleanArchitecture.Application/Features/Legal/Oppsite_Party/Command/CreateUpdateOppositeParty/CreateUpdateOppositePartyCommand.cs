using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Command.CreateUpdateOppositeParty
{
    public class CreateUpdateOppositePartyCommand : IRequest<CreateUpdateOppositePartyResponse>
    {
        public int PartyId { get; set; }
        public string PartyName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string PartyAddress { get; set; }
    }
}
