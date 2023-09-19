using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetCaseFilesByFileMasterId;
using CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourtGrid;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllDistrictByCourtId;
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
    public class CourtController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourtController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        [HttpPost]
        [Route("CreateUpdateCourt")]
        public async Task<ActionResult<string>> CreateUpdateCourt([FromBody] CreateUpdateCourtCommand createUpdateCourtCommand)
        {
            var response = await _mediator.Send(createUpdateCourtCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllCourt")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllCourtVm>>> GetAllCourt()
        {
            var allCourt = await _mediator.Send(new GetAllCourtQuery());
            return Ok(allCourt);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllCourtGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllCourtGridQuery() { options = options });
            return Ok(allData);
        }

        [HttpGet("districtByCourtId/{courtId}", Name = "GetDistrictByCourtId")]
        public async Task<ActionResult<GetAllDistrictByCourtIdVm>> GetDistrictByCourtId(int courtId)
        {
            var data = new GetAllDistrictByCourtIdQuery() { CourtId = courtId };
            var list = await _mediator.Send(data);
            return Ok(list);
        }
    }
}
