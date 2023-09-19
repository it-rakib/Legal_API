using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.Oppsite_Party.Queries.GetAllOppsiteParty
{
    public class GetAllOppsitePartyQuery : IRequest<List<GetAllOppsitePartyVm>>
    {
        public GridOptions options { get; set; }
    }
}
