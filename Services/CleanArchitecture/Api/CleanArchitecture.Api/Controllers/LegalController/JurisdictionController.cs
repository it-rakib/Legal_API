using CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo;
using CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileTypeGrid;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Command.CreateUpdateJurisdiction;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdiction;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionByCourtId;
using CleanArchitecture.Application.Features.Legal.Jurisdiction_Info.Queries.GetAllJurisdictionGrid;
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
    public class JurisdictionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JurisdictionController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }



        [HttpPost]
        [Route("CreateUpdateJurisdiction")]
        public async Task<ActionResult<string>> CreateUpdateCaseType([FromBody] CreateUpdateJurisdictionCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        

        [HttpGet("all", Name = "GetAllJurisdiction")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllJurisdictionVm>>> GetAllJurisdiction()
        {
            var all = await _mediator.Send(new GetAllJurisdictionQuery());
            return Ok(all);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllJurisdictionGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllJurisdictionGridQuery() { options = options });
            return Ok(allData);
        }

        [HttpGet("{courtId}", Name = "GetJurisdictionByCourtId")]
        public async Task<ActionResult<GetAllJurisdictionByCourtIdVm>> GetById(int courtId)
        {
            var result = new GetAllJurisdictionByCourtIdQuery() { CourtId = courtId };
            return Ok(await _mediator.Send(result));
        }
    }
}
