using Common.Service.Responses;

namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Command.CreateUpdatePetitioner
{
    public class CreateUpdatePetitionerResponse : BaseResponse
    {
        public CreateUpdatePetitionerResponse()
        {
        }
        public CreateUpdatePetitionerDto PetitionerDto { get; set; }
    }
}
