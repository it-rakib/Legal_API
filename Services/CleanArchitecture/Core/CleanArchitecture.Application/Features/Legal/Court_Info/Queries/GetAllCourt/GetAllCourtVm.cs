namespace CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt
{
    public class GetAllCourtVm
    {
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CourtNo { get; set; }
        public string CourtAddress { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int? DistrictId { get;set; }
    }
}
