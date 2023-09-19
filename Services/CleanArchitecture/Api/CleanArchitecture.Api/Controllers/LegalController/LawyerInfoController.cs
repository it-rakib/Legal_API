using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Command.CreateUpdateLawer;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyer;
using CleanArchitecture.Application.Features.Legal.Lawyer_Info.Queries.GetAllLawyerGrid;
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
    public class LawyerInfoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LawyerInfoController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateLawyer")]
        public async Task<ActionResult<string>> CreateUpdateLawyer([FromBody] CreateUpdateLawerCommand createUpdateLawerCommand)
        {
            var response = await _mediator.Send(createUpdateLawerCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllLawyer")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllLawyerVm>>> GetAllLawyer()
        {
            var allLawyer = await _mediator.Send(new GetAllLawyerQuery());
            return Ok(allLawyer);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllLawyerGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllLawyerGridQuery() { options = options });
            return Ok(allData);
        }
    }
}
