namespace CleanArchitecture.Application.Features.Legal.Lawyer_Info.Command.CreateUpdateLawer
{
    public class CreateUpdateLawerDto
    {
        public int LawyerId { get; set; }
        public string LawyerName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string LawyerAddress { get; set; }
    }
}
