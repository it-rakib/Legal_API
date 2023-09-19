using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Command.CreateUpdateJurisdiction
{
    public class CreateUpdateJurisdictionResponse : BaseResponse
    {
        public CreateUpdateJurisdictionResponse()
        {
        }
        public CreateUpdateJurisdictionDto jurisdictionDto { get; set; }
    }
}
