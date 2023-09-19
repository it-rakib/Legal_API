using CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
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
    public class CaseTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CaseTypeController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateCaseType")]
        public async Task<ActionResult<string>> CreateUpdateCaseType([FromBody] CreateUpdateCaseTypeCommand createUpdateCaseTypeCommand)
        {
            var response = await _mediator.Send(createUpdateCaseTypeCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllCaseType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllCaseTypeVm>>> GetAllCaseType()
        {
            var all = await _mediator.Send(new GetAllCaseTypeQuery());
            return Ok(all);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllCaseTypeGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllCaseTypeGridQuery() { options = options });
            return Ok(allData);
        }
    }
}
