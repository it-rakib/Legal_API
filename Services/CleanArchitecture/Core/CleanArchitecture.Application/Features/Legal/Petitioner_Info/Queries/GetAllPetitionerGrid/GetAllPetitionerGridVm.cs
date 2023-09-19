namespace CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitionerGrid
{
    public class GetAllPetitionerGridVm
    {
        public int PetitionerId { get; set; }
        public string PetitionerName { get; set; }
        public string Email { get; set; }
        public string PetitionerAddress { get; set; }
        public string ContactNo { get; set; }
    }
}
