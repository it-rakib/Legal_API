using MediatR;

namespace CleanArchitecture.Application.Features.Legal.Matter_Info.Command.CreateUpdateMatter
{
    public class CreateUpdateMatterCommand : IRequest<CreateUpdateMatterResponse>
    {
        public int MatterId { get; set; }
        public string MatterName { get; set; }
        public string Discription { get; set; }
    }
}
