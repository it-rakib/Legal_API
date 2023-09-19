using CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Command.CreateUpdateMatter;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterGrid;
using CleanArchitecture.Application.Features.Legal.Matter_Info.Queries.GetAllMatterInfo;
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
    public class MatterInfoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MatterInfoController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateMatter")]
        public async Task<ActionResult<string>> CreateUpdateMatter([FromBody] CreateUpdateMatterCommand createUpdateMatterCommand)
        {
            var response = await _mediator.Send(createUpdateMatterCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllMatterInfo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllMatterVm>>> GetAllMatterInfo()
        {
            var all = await _mediator.Send(new GetAllMatterQuery());
            return Ok(all);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllMatterGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllMatterGridQuery() { options = options });
            return Ok(allData);
        }
    }
}
