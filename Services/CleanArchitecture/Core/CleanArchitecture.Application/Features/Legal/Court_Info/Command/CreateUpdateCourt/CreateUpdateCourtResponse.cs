using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt
{
    public class CreateUpdateCourtResponse : BaseResponse
    {
        public CreateUpdateCourtResponse()
        {
        }
        public CreateUpdateCourtDto CourtDto { get; set; }
    }
}
