namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourtGrid
{
    public class GetAllCourtGridVm
    {
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CourtNo { get; set; }
        public string CourtAddress { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string JurisdictionId { get; set; }
        public string JurisdictionName { get; set; }        
    }
}
