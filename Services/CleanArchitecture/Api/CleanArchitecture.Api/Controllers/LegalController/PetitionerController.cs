using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Petitioner_Info.Command.CreateUpdatePetitioner;
using CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitioner;
using CleanArchitecture.Application.Features.Legal.Petitioner_Info.Queries.GetAllPetitionerGrid;
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
    public class PetitionerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PetitionerController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdatePetitioner")]
        public async Task<ActionResult<string>> CreateUpdatePetitioner([FromBody] CreateUpdatePetitionerCommand createUpdatePetitionerCommand)
        {
            var response = await _mediator.Send(createUpdatePetitionerCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllPetitioner")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllPetitionerVm>>> GetAllPetitioner()
        {
            var allCourt = await _mediator.Send(new GetAllPetitionerQuery());
            return Ok(allCourt);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllPetitionerGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllPetitionerGridQuery() { options = options });
            return Ok(allData);
        }
    }
}
