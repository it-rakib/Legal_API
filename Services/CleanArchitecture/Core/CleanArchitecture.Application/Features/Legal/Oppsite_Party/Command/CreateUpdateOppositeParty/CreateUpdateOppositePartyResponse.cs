using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Command.CreateUpdateOppositeParty
{
    public class CreateUpdateOppositePartyResponse : BaseResponse
    {
        public CreateUpdateOppositePartyResponse()
        {
        }
        public CreateUpdateOppositePartyDto partyDto { get; set; }
    }
}
