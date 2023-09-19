using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Oppsite_Party.Command.CreateUpdateOppositeParty;
using CleanArchitecture.Application.Features.Legal.Oppsite_Party.Queries.GetAllOppsiteParty;
using Common.Service.CommonEntities.KendoGrid;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Controllers.LegalController
{
    [Route("api/[controller]")]
    [ApiController]
    public class OppositePartyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OppositePartyController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateOppositeParty")]
        public async Task<ActionResult<string>> CreateUpdateOppositeParty([FromBody] CreateUpdateOppositePartyCommand createUpdateOppositePartyCommand)
        {
            var response = await _mediator.Send(createUpdateOppositePartyCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllOppositeParty")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllOppsitePartyVm>>> GetAllOppositeParty()
        {
            var allCourt = await _mediator.Send(new GetAllOppsitePartyQuery());
            return Ok(allCourt);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllOppsitePartyVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllOppsitePartyQuery() { options = options });
            return Ok(allData);
        }
    }
}
