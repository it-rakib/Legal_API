using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt
{
    public class CreateUpdateCourtCommand : IRequest<CreateUpdateCourtResponse>
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
        public virtual ICollection<DistrictWiseJurisdictionCommand> DistrictWiseJurisdictions { get; set; }

    }
    public class DistrictWiseJurisdictionCommand
    {
        public int DistrictWiseJurisdictionId { get; set; }
        public int? CourtId { get; set; }
        public int? DistrictId { get; set; }
        public int? JurisdictionId { get; set; }
    }

}
