using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllGridData;
using CleanArchitecture.Application.Features.Legal.Court_Info.Command.CreateUpdateCourt;
using CleanArchitecture.Application.Features.Legal.Court_Info.Queries.GetAllCourt;
using CleanArchitecture.Application.Features.Legal.File_Type.Command.CreateUpdateFileType;
using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileType;
using CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileTypeGrid;
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
    public class FileTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FileTypeController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("all", Name = "GetAllFileType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllFileTypeVm>>> GetAllFileType()
        {
            var all = await _mediator.Send(new GetAllFileTypeQuery());
            return Ok(all);
        }

        [HttpPost]
        [Route("CreateUpdateFileType")]
        public async Task<ActionResult<string>> CreateUpdateFileType([FromBody] CreateUpdateFileTypeCommand createUpdateFileTypeCommand)
        {
            var response = await _mediator.Send(createUpdateFileTypeCommand);
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllFileTypeGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllFileTypeGridQuery() { options = options });
            return Ok(allData);
        }
    }
}
